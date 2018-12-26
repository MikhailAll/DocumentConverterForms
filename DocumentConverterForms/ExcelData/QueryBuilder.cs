using System.Collections.Generic;
using System.Linq;
using DocumentConverterForms.Models;

namespace DocumentConverterForms.ExcelData
{
    public class QueryBuilder
    {
        private readonly string _sheetName;
        private readonly Profile _profile;

        public QueryBuilder(string sheetName, Profile profile)
        {
            _sheetName = sheetName;
            _profile = profile;
        }

        public string GetProfileKeyQuery()
        {
            var result = $"SELECT * FROM [{_sheetName}{_profile.ExcelParseSettings.ProfileKey}]";
            return result;
        }

        public string GetSubjectNameQuery()
        {
            var query =
                $"SELECT * FROM [{_sheetName}{_profile.ExcelParseSettings.SubjectName}:{_profile.ExcelParseSettings.SubjectName}]";
            return query;
        }

        private string GetSelectQuery(string parseSettingsProperty)
        {
            if (!string.IsNullOrEmpty(parseSettingsProperty))
            {
                var query = $"SELECT * FROM [{_sheetName}{parseSettingsProperty}:{parseSettingsProperty}]";
                return query;
            }

            return null;
        }

        public Dictionary<string, string> BuildInsertQueries(Subject subject)
        {
            var queryDictionary = new Dictionary<string, string>()
            {
                //{"SubjectName", $"UPDATE [{_sheetName}{_profile.ExcelParseSettings.SubjectName}{subject.RowIndex}:{_profile.ExcelParseSettings.SubjectName}{subject.RowIndex}] SET F1 = \"{subject.SubjectName}\""},
                //{"CW", $"UPDATE [{_sheetName}{_profile.ExcelParseSettings.CW}{subject.RowIndex}:{_profile.ExcelParseSettings.CW}{subject.RowIndex}] SET F1 = '{subject.CW}'"},
                //{"ECTS", $"UPDATE [{_sheetName}{_profile.ExcelParseSettings.ECTS}{subject.RowIndex}:{_profile.ExcelParseSettings.ECTS}{subject.RowIndex}] SET F1 = '{subject.ECTS}'"},
                //{"TotalHours", $"UPDATE [{_sheetName}{_profile.ExcelParseSettings.TotalHours}{subject.RowIndex}:{_profile.ExcelParseSettings.TotalHours}{subject.RowIndex}] SET F1 = '{subject.TotalHours}'"},
                //{"TotalClassroomHours", $"UPDATE [{_sheetName}{_profile.ExcelParseSettings.TotalClassroomHours}{subject.RowIndex}:{_profile.ExcelParseSettings.TotalClassroomHours}{subject.RowIndex}] SET F1 = '{subject.TotalClassroomHours}'"},
                //{"Lectures", $"UPDATE [{_sheetName}{_profile.ExcelParseSettings.Lectures}{subject.RowIndex}:{_profile.ExcelParseSettings.Lectures}{subject.RowIndex}] SET F1 = '{subject.Lectures}'"},
                //{"PracticalWorks", $"UPDATE [{_sheetName}{_profile.ExcelParseSettings.PracticalWorks}{subject.RowIndex}:{_profile.ExcelParseSettings.PracticalWorks}{subject.RowIndex}] SET F1 = '{subject.PracticalWorks}'"},
                //{"LaboratoryWorks", $"UPDATE [{_sheetName}{_profile.ExcelParseSettings.LaboratoryWorks}{subject.RowIndex}:{_profile.ExcelParseSettings.LaboratoryWorks}{subject.RowIndex}] SET F1 = '{subject.LaboratoryWorks}'"},
                //{"Consultation", $"UPDATE [{_sheetName}{_profile.ExcelParseSettings.Consultation}{subject.RowIndex}:{_profile.ExcelParseSettings.Consultation}{subject.RowIndex}] SET F1 = '{subject.Consultation}'"},
                //{"SelfEducation", $"UPDATE [{_sheetName}{_profile.ExcelParseSettings.SelfEducation}{subject.RowIndex}:{_profile.ExcelParseSettings.SelfEducation}{subject.RowIndex}] SET F1 = '{subject.SelfEducation}'"}
            };

            for (var i = 0; i < subject.Semesters.Count; i++)
            {
                var semesterNumber = subject.Semesters[i].SemesterNumber;
                var parseSettings = _profile.ExcelParseSettings.SemesterSettings.FirstOrDefault(s => s.SemesterNumber == semesterNumber);
                queryDictionary.Add($"{semesterNumber}Lectures",
                    $"UPDATE [{_sheetName}{parseSettings.Lectures}{subject.RowIndex + 1}:{parseSettings.Lectures}{subject.RowIndex + 1}] SET F1 = '{subject.Semesters[i].Lectures}'");
                queryDictionary.Add($"{semesterNumber}PracticalWorks",
                    $"UPDATE [{_sheetName}{parseSettings.PracticalWorks}{subject.RowIndex + 1}:{parseSettings.PracticalWorks}{subject.RowIndex + 1}] SET F1 = '{subject.Semesters[i].PracticalWorks}'");
                queryDictionary.Add($"{semesterNumber}LaboratoryWorks",
                    $"UPDATE [{_sheetName}{parseSettings.LaboratoryWorks}{subject.RowIndex + 1}:{parseSettings.LaboratoryWorks}{subject.RowIndex + 1}] SET F1 = '{subject.Semesters[i].LaboratoryWorks}'");
                queryDictionary.Add($"{semesterNumber}Consultation",
                    $"UPDATE [{_sheetName}{parseSettings.Consultation}{subject.RowIndex + 1}:{parseSettings.Consultation}{subject.RowIndex + 1}] SET F1 = '{subject.Semesters[i].Consultation}'");
            }

            return queryDictionary;
        }

        public Dictionary<string, string> BuildDataQueries()
        {
            var queryDictionary = new Dictionary<string, string>()
            {
                {"ECTS", GetSelectQuery(_profile.ExcelParseSettings.ECTS)},
                {"TotalHours", GetSelectQuery(_profile.ExcelParseSettings.TotalHours)},
                {"TotalClassroomHours", GetSelectQuery(_profile.ExcelParseSettings.TotalClassroomHours)},
                {"Lectures", GetSelectQuery(_profile.ExcelParseSettings.Lectures)},
                {"PracticalWorks", GetSelectQuery(_profile.ExcelParseSettings.PracticalWorks)},
                {"LaboratoryWorks", GetSelectQuery(_profile.ExcelParseSettings.LaboratoryWorks)},
                {"Consultation", GetSelectQuery(_profile.ExcelParseSettings.Consultation)},
                {"SelfEducation", GetSelectQuery(_profile.ExcelParseSettings.SelfEducation)},
            };

            queryDictionary = queryDictionary
                .Where(query => !string.IsNullOrWhiteSpace(query.Value))
                .ToDictionary(item => item.Key, item => item.Value);

            return queryDictionary;
        }

        public Dictionary<string, string> BuildCountQueries()
        {
            var queryDictionary = new Dictionary<string, string>()
            {
                {"CreditList", GetSelectQuery(_profile.ExcelParseSettings.Credit)},
                {"ExamList", GetSelectQuery(_profile.ExcelParseSettings.Exam)}
            };

            queryDictionary = queryDictionary
                .Where(query => !string.IsNullOrWhiteSpace(query.Value))
                .ToDictionary(item => item.Key, item => item.Value);

            return queryDictionary;
        }

        public Dictionary<int, List<string>> BuildSemesterQueries()
        {
            var queryDictionary = new Dictionary<int, List<string>>();

            foreach (var semester in _profile.ExcelParseSettings.SemesterSettings)
            {
                var queryList = new List<string>();

                if (GetSelectQuery(semester.Lectures) != null) queryList.Add(GetSelectQuery(semester.Lectures));
                if (GetSelectQuery(semester.LaboratoryWorks) != null)
                    queryList.Add(GetSelectQuery(semester.LaboratoryWorks));
                if (GetSelectQuery(semester.PracticalWorks) != null)
                    queryList.Add(GetSelectQuery(semester.PracticalWorks));
                if (GetSelectQuery(semester.Consultation) != null) queryList.Add(GetSelectQuery(semester.Consultation));

                queryDictionary.Add(semester.SemesterNumber, queryList);
            }

            return queryDictionary;
        }

        public string BuildCWQuery()
        {
            return GetSelectQuery(_profile.ExcelParseSettings.CW);
        }
    }
}