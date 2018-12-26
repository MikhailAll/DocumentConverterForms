using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DocumentConverterForms.Models
{
    public class Subject : ICloneable
    {
        [Browsable(false)]
        public int RowIndex { get; set; }
        [DisplayName("Дисциплина")]
        public string SubjectName { get; set; }
        [DisplayName("Зач")]
        public int Credit => CreditList.Count;
        [DisplayName("Экз")]
        public int Exam => ExamList.Count;
        [DisplayName("КР")]
        public int CW { get; set; }
        [DisplayName("Кред")]
        public double ECTS { get; set; }
        [DisplayName("ОКЧ")]
        public int TotalHours { get; set; }
        [DisplayName("ОКАЧ")]
        public int TotalClassroomHours { get; set; }
        [DisplayName("ЛК")]
        public int Lectures { get; set; }
        [DisplayName("ПЗ")]
        public int PracticalWorks { get; set; }
        [DisplayName("ЛБ")]
        public int LaboratoryWorks { get; set; }
        [DisplayName("Конс")]
        public int Consultation { get; set; }
        [DisplayName("СР")]
        public int SelfEducation { get; set; }

        public List<Semester> Semesters { get; set; }
        public List<int> CreditList { get; set; }
        public List<int> ExamList { get; set; }

        public object Clone()
        {
            return new Subject()
            {
                RowIndex = this.RowIndex,
                SubjectName = this.SubjectName,
                CW = this.CW,
                ECTS = this.ECTS,
                TotalHours = this.TotalHours,
                TotalClassroomHours = this.TotalClassroomHours,
                Lectures = this.Lectures,
                PracticalWorks = this.PracticalWorks,
                LaboratoryWorks = this.LaboratoryWorks,
                Consultation = this.Consultation,
                SelfEducation = this.SelfEducation,
                Semesters = this.Semesters.ConvertAll(semester => semester.Clone() as Semester),
                CreditList = this.CreditList.ToList(),
                ExamList = this.ExamList.ToList()
            };
        }
    }
}