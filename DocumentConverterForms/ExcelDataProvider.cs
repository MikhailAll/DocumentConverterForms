using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentConverterForms
{
    class ExcelDataProvider
    {
        private string _excelFilePath;
        private readonly string _connectionString;
        private List<Subject> _subjects;

        public ExcelDataProvider(string excelFilePath)
        {
            _excelFilePath = excelFilePath;

            if (excelFilePath.EndsWith(".xls"))
            {
                _connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; 
                                      Data Source = " + excelFilePath + @";
                                      Extended Properties = 'Excel 8.0;HDR=No;IMEX=1';";
            }
            else if (excelFilePath.EndsWith(".xlsx"))
            {
                _connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                                      Data Source=" + excelFilePath + @";
                                      Extended Properties='Excel 12.0 Xml;HDR=No';";
            }
            else
            {
                throw new ArgumentException("Input string is empty or wrong format");
            }
        }

        private DataSet GetDataSet(string query, OleDbConnection connection)
        {
            var dataAdapter = new OleDbDataAdapter(query, connection);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }

        private string GetSheetName(int sheetIndex)
        {
            using (var connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                var dataTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                    new object[] {null, null, null, "TABLE"});
                var sheetName = dataTable.Rows[sheetIndex].Field<string>("TABLE_NAME");
                connection.Close();
                return sheetName.Replace("Print_Area", "");
            }
        }

        private int GetDocumentRowCount(int sheetNumber)
        {
            using (var connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                var dataSet = GetDataSet($"SELECT * FROM [{GetSheetName(sheetNumber)}A:A]", connection);
                connection.Close();
                
                return dataSet.Tables[0].Rows.Count;
            }
        }

        public bool IsProfileMatch(Profile profile)
        {
            using (var connection = new OleDbConnection(_connectionString))
            {
                var query = new QueryBuilder(
                        GetSheetName(profile.ExcelParseSettings.SheetNumber),
                        profile)
                    .GetProfileKeyQuery();

                connection.Open();
                var dataSet = GetDataSet(query, connection);
                connection.Close();

                var documentKey = new StringBuilder();
                foreach (var dataRow in dataSet.Tables[0].AsEnumerable())
                {
                    documentKey.Append(dataRow.ItemArray[0]);
                }

                return documentKey.GetHashCode() == profile.ProfileKey;
            }
        }

        private List<Subject> SubjectInit(Profile profile)
        {
            using (var connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                var subjectList = new List<Subject>();
                var query = new QueryBuilder(
                        GetSheetName(profile.ExcelParseSettings.SheetNumber),
                        profile)
                    .GetSubjectNameQuery();

                var dataSet = GetDataSet(query, connection);

                foreach (var dataRow in dataSet.Tables[0].AsEnumerable())
                {
                    var data = dataRow.ItemArray[0].ToString().Trim();
                    if (!string.IsNullOrEmpty(data) &&
                        !profile.ExcelParseSettings.ParseExceptions.Any(s => data.Contains(s)))
                        subjectList.Add(new Subject()
                        {
                            SubjectName = data, RowIndex = dataSet.Tables[0].Rows.IndexOf(dataRow),
                            Semesters = new List<Semester>(),
                            CreditList = new List<int>(),
                            ExamList = new List<int>()
                        });
                }

                connection.Close();
                return subjectList;
            }
        }

        private List<Subject> CleanBasicData(List<Subject> rawSubjects)
        {
            var cleanedSubjects = new List<Subject>(rawSubjects);

            foreach (var subject in rawSubjects)
            {
                if (subject.ECTS == 0 &&
                    subject.TotalHours == 0 &&
                    subject.TotalClassroomHours == 0 &&
                    subject.Lectures == 0 &&
                    subject.PracticalWorks == 0 &&
                    subject.LaboratoryWorks == 0 &&
                    subject.Consultation == 0 &&
                    subject.SelfEducation == 0)
                    cleanedSubjects.Remove(subject);

                if (subject.SubjectName.All(char.IsDigit))
                    cleanedSubjects.Remove(subject);
            }

            return cleanedSubjects;
        }

        private List<Subject> ParseBasicData(Profile profile)
        {
            var queriesDictionary = new QueryBuilder(GetSheetName(profile.ExcelParseSettings.SheetNumber), profile)
                .BuildDataQueries();

            using (var connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                var subjectList = SubjectInit(profile);

                foreach (var query in queriesDictionary)
                {
                    if (!string.IsNullOrEmpty(query.Value))
                    {
                        var dataSet = GetDataSet(query.Value, connection);

                        foreach (var subject in subjectList)
                        {
                            var data = dataSet.Tables[0].Rows[subject.RowIndex].ItemArray[0].ToString();
                            var property = subject.GetType().GetProperty(query.Key);
                            try
                            {
                                property.SetValue(subject, Convert.ChangeType(data, property.PropertyType));
                            }
                            catch (FormatException)
                            {
                                property.SetValue(subject, 0);
                            }
                        }
                    }
                }

                connection.Close();

                return subjectList;
            }
        }

        private List<Subject> ParseCWData(Profile profile, List<Subject> subjects)
        {
            var query = new QueryBuilder(GetSheetName(profile.ExcelParseSettings.SheetNumber), profile)
                .BuildCWQuery();

            using (var connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                var dataSet = GetDataSet(query, connection);
                foreach (var subject in subjects)
                {
                    var data = dataSet.Tables[0].Rows[subject.RowIndex].ItemArray[0].ToString().FirstOrDefault(char.IsDigit);
                    subject.CW = data == '\0' ? 0 :(int) char.GetNumericValue(data);
                }

                connection.Close();
            }

            return subjects;
        }

        private List<Subject> ParseCountData(Profile profile, List<Subject> subjects)
        {
            var queriesDictionary = new QueryBuilder(GetSheetName(profile.ExcelParseSettings.SheetNumber), profile)
                .BuildCountQueries();

            using (var connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                var creditDataSet = GetDataSet(queriesDictionary["CreditList"], connection);
                var examDataSet = GetDataSet(queriesDictionary["ExamList"], connection);
                foreach (var subject in subjects)
                {
                    var creditData = creditDataSet.Tables[0].Rows[subject.RowIndex].ItemArray[0].ToString();
                    var examData = examDataSet.Tables[0].Rows[subject.RowIndex].ItemArray[0].ToString();

                    var credits = creditData.Split(',', '.');
                    foreach(var credit in credits)
                        if (!string.IsNullOrWhiteSpace(credit))
                            subject.CreditList.Add(int.Parse(credit));

                    var exams = examData.Split(',', '.');
                    foreach (var exam in exams)
                        if (!string.IsNullOrWhiteSpace(exam))
                            subject.ExamList.Add(int.Parse(exam));
                }

                connection.Close();
            }

            return subjects;
        }

        private List<Subject> ParseSemesterData(Profile profile, List<Subject> subjects)
        {
            var queriesDictionary = new QueryBuilder(GetSheetName(profile.ExcelParseSettings.SheetNumber), profile)
                .BuildSemesterQueries();

            using (var connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                foreach (var queryList in queriesDictionary)
                {
                    var lecturesDataSet = queryList.Value.ElementAtOrDefault(0) != null ? GetDataSet(queryList.Value[0], connection): null;
                    var practicalWorksDataSet = queryList.Value.ElementAtOrDefault(1) != null ? GetDataSet(queryList.Value[1], connection) : null;
                    var laboratoryWorksDataSet = queryList.Value.ElementAtOrDefault(2) != null ? GetDataSet(queryList.Value[2], connection) : null;
                    var consultationDataSet = queryList.Value.ElementAtOrDefault(3) != null ? GetDataSet(queryList.Value[3], connection) : null;

                    foreach (var subject in subjects)
                    {
                        var lecturesData = lecturesDataSet?.Tables[0].Rows[subject.RowIndex].ItemArray[0].ToString();
                        var practicalWorksData = practicalWorksDataSet?.Tables[0].Rows[subject.RowIndex].ItemArray[0]
                            .ToString();
                        var laboratoryWorksData = laboratoryWorksDataSet?.Tables[0].Rows[subject.RowIndex].ItemArray[0]
                            .ToString();
                        var consultationData = consultationDataSet?.Tables[0].Rows[subject.RowIndex].ItemArray[0]
                            .ToString();

                        if (string.IsNullOrWhiteSpace(lecturesData))
                            lecturesData = "0";
                        if (string.IsNullOrWhiteSpace(practicalWorksData))
                            practicalWorksData = "0";
                        if (string.IsNullOrWhiteSpace(laboratoryWorksData))
                            laboratoryWorksData = "0";
                        if (string.IsNullOrWhiteSpace(consultationData))
                            consultationData = "0";

                        var semester = new Semester()
                        {
                            SemesterNumber = queryList.Key,
                            Lectures = Convert.ToInt32(lecturesData),
                            PracticalWorks = Convert.ToInt32(practicalWorksData),
                            LaboratoryWorks = Convert.ToInt32(laboratoryWorksData),
                            Consultation = Convert.ToInt32(consultationData)
                        };

                        subject.Semesters.Add(semester);
                    }
                }

                connection.Close();
            }
            return subjects;
        }

        private int GetProfileKey(Profile profile)
        {
            using (var connection = new OleDbConnection(_connectionString))
            {
                var query = new QueryBuilder(
                        GetSheetName(profile.ExcelParseSettings.SheetNumber),
                        profile)
                    .GetProfileKeyQuery();

                connection.Open();
                var dataSet = GetDataSet(query, connection);
                connection.Close();

                var documentKey = new StringBuilder();
                foreach (var dataRow in dataSet.Tables[0].AsEnumerable())
                {
                    documentKey.Append(dataRow.ItemArray[0]);
                }

                return documentKey.GetHashCode();
            }
        }

        public void SaveData(Profile profile, List<Subject> subjects)
        {
             using (var connection = new OleDbConnection(_connectionString.Replace("IMEX=1", "")))
             {
                 connection.Open();
                 var queryBuilder =
                     new QueryBuilder(GetSheetName(profile.ExcelParseSettings.SheetNumber), profile);
                 var myCommand = new OleDbCommand()
                 {
                     Connection = connection
                 };

                 foreach (var subject in subjects)
                 {
                     var queriesDictionary = queryBuilder.BuildInsertQueries(subject);
                     foreach (var query in queriesDictionary.Values)
                     {
                         try
                         {
                             myCommand.CommandText = query;
                             myCommand.ExecuteNonQuery();
                        }
                         catch (OleDbException)
                         {
                             continue;
                         }
                     }
                 }
             }
        }

        public List<Subject> LoadData(Profile profile)
        {
            if (profile.ProfileKey == 0)
                profile.ProfileKey = GetProfileKey(profile);

            var subjects = ParseSemesterData(profile,
                ParseCWData(profile,
                    ParseCountData(profile,
                        CleanBasicData(
                            ParseBasicData(profile)))));


            return subjects;
        }
    }
}
