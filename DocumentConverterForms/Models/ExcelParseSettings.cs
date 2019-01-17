using System.ComponentModel;

namespace DocumentConverterForms.Models
{
    public class ExcelParseSettings
    {
        public int SheetNumber { get; set; }
        public string ProfileKey { get; set; }

        public string SubjectName { get; set; }
        public string Credit { get; set; }
        public string Exam { get; set; }
        public string CW { get; set; }
        public string ECTS { get; set; }
        public string TotalHours { get; set; }
        public string TotalClassroomHours { get; set; }
        public string Lectures { get; set; }
        public string PracticalWorks { get; set; }
        public string LaboratoryWorks { get; set; }
        public string Consultation { get; set; }
        public string SelfEducation { get; set; }
        public bool IsMaster { get; set; }

        public BindingList<SemesterSettings> SemesterSettings { get; set; }
        public BindingList<string> ParseExceptions { get; set; }
    }
}