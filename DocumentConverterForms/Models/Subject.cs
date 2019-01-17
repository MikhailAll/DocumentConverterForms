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
        [Browsable(false)]
        public bool IsAffectingCalculation { get; set; }
        [Browsable(false)]
        public bool IsHumanitarian { get; set; }
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
            return new Subject
            {
                RowIndex = RowIndex,
                IsAffectingCalculation = IsAffectingCalculation,
                IsHumanitarian = IsHumanitarian,
                SubjectName = SubjectName,
                CW = CW,
                ECTS = ECTS,
                TotalHours = TotalHours,
                TotalClassroomHours = TotalClassroomHours,
                Lectures = Lectures,
                PracticalWorks = PracticalWorks,
                LaboratoryWorks = LaboratoryWorks,
                Consultation = Consultation,
                SelfEducation = SelfEducation,
                Semesters = Semesters.ConvertAll(semester => semester.Clone() as Semester),
                CreditList = CreditList.ToList(),
                ExamList = ExamList.ToList()
            };
        }
    }
}