using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentConverterForms
{
    public class Semester : ICloneable
    {
        public int SemesterNumber { get; set; }
        public int Lectures { get; set; }
        public int PracticalWorks { get; set; }
        public int LaboratoryWorks { get; set; }
        public int Consultation { get; set; }

        public object Clone()
        {
            return new Semester()
            {
                SemesterNumber = this.SemesterNumber,
                Lectures = this.Lectures,
                PracticalWorks = this.PracticalWorks,
                LaboratoryWorks = this.LaboratoryWorks,
                Consultation = this.Consultation
            };
        }
    }
}
