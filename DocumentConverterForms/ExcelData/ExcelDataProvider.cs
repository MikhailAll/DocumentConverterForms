using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using DocumentConverterForms.Models;

namespace DocumentConverterForms.ExcelData
{
    public class ExcelDataProvider
    {
        private readonly string _connectionString;
        private List<Subject> _subjects;

        public ExcelDataProvider(string excelFilePath)
        {
            _subjects = new List<Subject>();

            if (excelFilePath.EndsWith(".xls"))
                _connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; 
                                      Data Source = " + excelFilePath + @";
                                      Extended Properties = 'Excel 8.0;HDR=No;IMEX=1';";
            else if (excelFilePath.EndsWith(".xlsx"))
                _connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                                      Data Source=" + excelFilePath + @";
                                      Extended Properties='Excel 12.0 Xml;HDR=No';";
            else
                throw new ArgumentException("Input string is empty or wrong format");
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
                foreach (var dataRow in dataSet.Tables[0].AsEnumerable()) documentKey.Append(dataRow.ItemArray[0]);

                return documentKey.ToString() == profile.ProfileKey;
            }
        }

        private void SubjectInit(Profile profile)
        {
            using (var connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                var query = new QueryBuilder(
                        GetSheetName(profile.ExcelParseSettings.SheetNumber),
                        profile)
                    .GetSubjectNameQuery();

                var dataSet = GetDataSet(query, connection);
                var dataIsBlock = false;
                var dataIsFirstBlock = false;
                var dataIsHumanitarian = false;

                foreach (var dataRow in dataSet.Tables[0].AsEnumerable())
                {
                    var data = dataRow.ItemArray[0].ToString().Trim();

                    if (data.ToLower().Contains("блок"))
                        dataIsBlock = true;
                    if (dataIsBlock && data.ToLower().Contains("1"))
                        dataIsFirstBlock = true;
                    if (data.ToLower().Contains("гуманітарні та соціально") && data.ToLower().Contains("вибіркові"))
                        dataIsHumanitarian = true;
                    if (data.ToLower().Contains("всього"))
                    {
                        dataIsBlock = false;
                        dataIsFirstBlock = false;
                        dataIsHumanitarian = false;
                    }

                    if (!string.IsNullOrEmpty(data))
                        _subjects.Add(new Subject
                        {
                            SubjectName = data, RowIndex = dataSet.Tables[0].Rows.IndexOf(dataRow),
                            IsAffectingCalculation = !dataIsBlock || dataIsFirstBlock ,
                            IsHumanitarian = dataIsHumanitarian,
                            Semesters = new List<Semester>(),
                            CreditList = new List<int>(),
                            ExamList = new List<int>()
                        });
                }

                connection.Close();
            }
        }

        private void SetCalculationAffectionForHumanitarianBlock(Profile profile)
        {
            _subjects.ForEach(subject =>
            {
                if (subject.IsHumanitarian)
                    subject.IsAffectingCalculation = false;
            });

            foreach (var semesterSettings in profile.ExcelParseSettings.SemesterSettings)
            {
                var subject = _subjects.FirstOrDefault(s =>
                    s.IsHumanitarian && s.Semesters[semesterSettings.SemesterNumber - 1].Lectures != 0);
                if (subject != null) subject.IsAffectingCalculation = true;
            }
        }

        private void CleanBasicData(Profile profile)
        {
            var cleanedSubjects = new List<Subject>(_subjects);
            foreach (var subject in _subjects)
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

                if (profile.ExcelParseSettings.ParseExceptions.Any(s => subject.SubjectName.Contains(s)))
                    cleanedSubjects.Remove(subject);
            }

            _subjects = cleanedSubjects;
        }

        private void ParseBasicData(Profile profile)
        {
            var queriesDictionary = new QueryBuilder(GetSheetName(profile.ExcelParseSettings.SheetNumber), profile)
                .BuildDataQueries();

            using (var connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                SubjectInit(profile);

                foreach (var query in queriesDictionary)
                {
                    if (string.IsNullOrEmpty(query.Value)) continue;
                    var dataSet = GetDataSet(query.Value, connection);

                    foreach (var subject in _subjects)
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

                connection.Close();
            }
        }

        private void ParseCWData(Profile profile)
        {
            var query = new QueryBuilder(GetSheetName(profile.ExcelParseSettings.SheetNumber), profile)
                .BuildCWQuery();

            using (var connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                var dataSet = GetDataSet(query, connection);
                foreach (var subject in _subjects)
                {
                    var data = dataSet.Tables[0].Rows[subject.RowIndex].ItemArray[0].ToString()
                        .FirstOrDefault(char.IsDigit);
                    subject.CW = data == '\0' ? 0 : (int) char.GetNumericValue(data);
                }

                connection.Close();
            }
        }

        private void ParseCountData(Profile profile)
        {
            var queriesDictionary = new QueryBuilder(GetSheetName(profile.ExcelParseSettings.SheetNumber), profile)
                .BuildCountQueries();

            using (var connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                var creditDataSet = GetDataSet(queriesDictionary["CreditList"], connection);
                var examDataSet = GetDataSet(queriesDictionary["ExamList"], connection);
                foreach (var subject in _subjects)
                {
                    var creditData = creditDataSet.Tables[0].Rows[subject.RowIndex].ItemArray[0].ToString();
                    var examData = examDataSet.Tables[0].Rows[subject.RowIndex].ItemArray[0].ToString();

                    var credits = creditData.Split(',', '.');
                    foreach (var credit in credits)
                        if (!string.IsNullOrWhiteSpace(credit))
                            subject.CreditList.Add(int.Parse(credit));

                    var exams = examData.Split(',', '.');
                    foreach (var exam in exams)
                        if (!string.IsNullOrWhiteSpace(exam))
                            subject.ExamList.Add(int.Parse(exam));
                }

                connection.Close();
            }
        }

        private void ParseSemesterData(Profile profile)
        {
            var queriesDictionary = new QueryBuilder(GetSheetName(profile.ExcelParseSettings.SheetNumber), profile)
                .BuildSemesterQueries();

            using (var connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                foreach (var queryList in queriesDictionary)
                {
                    var lecturesDataSet = queryList.Value.ElementAtOrDefault(0) != null
                        ? GetDataSet(queryList.Value[0], connection)
                        : null;
                    var practicalWorksDataSet = queryList.Value.ElementAtOrDefault(1) != null
                        ? GetDataSet(queryList.Value[1], connection)
                        : null;
                    var laboratoryWorksDataSet = queryList.Value.ElementAtOrDefault(2) != null
                        ? GetDataSet(queryList.Value[2], connection)
                        : null;
                    var consultationDataSet = queryList.Value.ElementAtOrDefault(3) != null
                        ? GetDataSet(queryList.Value[3], connection)
                        : null;

                    foreach (var subject in _subjects)
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

                        var semester = new Semester
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
        }

        private string GetProfileKey(Profile profile)
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
                foreach (var dataRow in dataSet.Tables[0].AsEnumerable()) documentKey.Append(dataRow.ItemArray[0]);

                return documentKey.ToString();
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

        public List<Subject> LoadData(Profile profile)
        {
            if (string.IsNullOrEmpty(profile.ProfileKey))
                profile.ProfileKey = GetProfileKey(profile);

            ParseBasicData(profile);
            CleanBasicData(profile);
            ParseCountData(profile);
            ParseCWData(profile);
            ParseSemesterData(profile);
            SetCalculationAffectionForHumanitarianBlock(profile);

            return _subjects;
        }
    }
}