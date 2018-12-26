using System;
using System.Collections.Generic;
using System.Linq;
using DocumentConverterForms.Models;

namespace DocumentConverterForms.ExcelData
{
    public class DataConverter
    {
        private readonly Profile _profile;
        private readonly List<Subject> _subjects;

        public DataConverter(Profile profile, List<Subject> subjects)
        {
            _profile = profile;
            _subjects = subjects;
        }

        public List<Subject> Convert()
        {
            var convertedSubjects = _subjects.ConvertAll(s => s.Clone() as Subject);
            foreach (var subject in convertedSubjects)
                subject.Semesters.RemoveAll(s => s.Lectures == 0 && s.LaboratoryWorks == 0 && s.PracticalWorks == 0);

            foreach (var semesterSetting in _profile.ExcelParseSettings.SemesterSettings)
            {
                var coefficient = GetCoefficient(semesterSetting, convertedSubjects);

                foreach (var subject in convertedSubjects)
                    if (subject.Semesters.Any(s => s.SemesterNumber == semesterSetting.SemesterNumber))
                    {
                        var totalHours = (int) Math.Round(coefficient * subject.ECTS / subject.Semesters.Count);
                        if (totalHours % 2 != 0) totalHours++;

                        var semester = subject.Semesters.Find(s => s.SemesterNumber == semesterSetting.SemesterNumber);

                        semester.Lectures = _profile.FileConversionSettings.MinLecturesCount;
                        semester.PracticalWorks = _profile.FileConversionSettings.MinPracticalWorksCount;
                        semester.LaboratoryWorks = totalHours - _profile.FileConversionSettings.MinLecturesCount -
                                                   _profile.FileConversionSettings.MinPracticalWorksCount;
                        if (semester.LaboratoryWorks < 0) semester.LaboratoryWorks = 0;
                    }
            }
            RecalculateTotalInfo(convertedSubjects);

            return convertedSubjects;
        }

        private void RecalculateTotalInfo(List<Subject> subjects)
        {
            foreach (var subject in subjects)
            {
                subject.Lectures = subject.Semesters.Sum(s => s.Lectures);
                subject.PracticalWorks = subject.Semesters.Sum(s => s.PracticalWorks);
                subject.LaboratoryWorks = subject.Semesters.Sum(s => s.LaboratoryWorks);
                subject.Consultation = subject.Semesters.Sum(s => s.Consultation);
                subject.TotalClassroomHours = subject.Lectures + subject.PracticalWorks + subject.LaboratoryWorks +
                                              subject.Consultation;
                subject.SelfEducation = subject.TotalHours - subject.TotalClassroomHours;
            }
            
        }

        private double GetCoefficient(SemesterSettings semesterSetting, List<Subject> subjects)
        {
            var examCount = 0;
            var creditCount = 0;
            var cwCount = 0;
            double ectsCount = 0;
            double coefficient;

            foreach (var subject in subjects)
                if (subject.Semesters.Any(s=> s.SemesterNumber == semesterSetting.SemesterNumber))
                {
                    if (subject.ExamList.Contains(semesterSetting.SemesterNumber))
                        examCount ++;
                    if (subject.CW != 0)
                        cwCount++;
                    if (subject.CreditList.Contains(semesterSetting.SemesterNumber))
                        creditCount ++;

                    ectsCount += subject.ECTS / subject.Semesters.Count;
                }

            if (semesterSetting.SemesterNumber < 5)
                coefficient = (135 - examCount * 18 - creditCount * 2 - cwCount * 6) / ectsCount;
            else
                coefficient = (135 - examCount * 18 - creditCount * 2 - cwCount * 6) / ectsCount;

            return coefficient;
        }
    }
}