﻿using System;
using System.ComponentModel;

namespace DocumentConverterForms.Models
{
    public class Semester : ICloneable
    {
        [DisplayName("Номер")]
        public int SemesterNumber { get; set; }
        [DisplayName("ЛК")]
        public int Lectures { get; set; }
        [DisplayName("ПЗ")]
        public int PracticalWorks { get; set; }
        [DisplayName("ЛБ")]
        public int LaboratoryWorks { get; set; }
        [DisplayName("Консультации")]
        public int Consultation { get; set; }

        public object Clone()
        {
            return new Semester
            {
                SemesterNumber = SemesterNumber,
                Lectures = Lectures,
                PracticalWorks = PracticalWorks,
                LaboratoryWorks = LaboratoryWorks,
                Consultation = Consultation
            };
        }
    }
}