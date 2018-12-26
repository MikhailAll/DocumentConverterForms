using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentConverterForms
{
    public class Subject : ICloneable
    {
        [Browsable(false)]
        public int RowIndex { get; set; }
        [DisplayName("Дисциплина")]
        public string SubjectName { get; set; }
        public int Credit => CreditList.Count;
        public int Exam => ExamList.Count;
        public int CW { get; set; }
        public double ECTS { get; set; }
        public int TotalHours { get; set; }
        public int TotalClassroomHours { get; set; }
        public int Lectures { get; set; }
        public int PracticalWorks { get; set; }
        public int LaboratoryWorks { get; set; }
        public int Consultation { get; set; }
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
