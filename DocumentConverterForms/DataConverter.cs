using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentConverterForms
{
    class DataConverter
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
            {
                subject.Semesters.Clear();
            }

            foreach (var semesterSetting in _profile.ExcelParseSettings.SemesterSettings)
            {
                double coefficient = GetCoefficient(semesterSetting);

                foreach (var subject in _subjects)
                {
                    if (subject.ExamList.Contains(semesterSetting.SemesterNumber) ||
                        subject.CreditList.Contains(semesterSetting.SemesterNumber))
                    {
                        var totalHours = (int)Math.Round(coefficient * subject.Semesters.Count(s => s.Lectures != 0 || s.LaboratoryWorks != 0 || s.PracticalWorks != 0));
                        if (totalHours % 2 != 0) totalHours++;

                        var semester = new Semester()
                        {
                            SemesterNumber = semesterSetting.SemesterNumber,
                            Lectures = _profile.FileConversionSettings.MinLecturesCount,
                            PracticalWorks = _profile.FileConversionSettings.MinPracticalWorksCount,
                            LaboratoryWorks = totalHours - _profile.FileConversionSettings.MinLecturesCount -
                                              _profile.FileConversionSettings.MinPracticalWorksCount
                        };

                        var convertedSubject = convertedSubjects.Find(s => s.RowIndex == subject.RowIndex);
                        convertedSubject.Semesters.Add(semester);
                    }
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

        private double GetCoefficient(SemesterSettings semesterSetting)
        {
            int examCount = 0;
            int creditCount = 0;
            int CWCount = 0;
            double ECTSCount = 0;
            double coefficient = 0;

            foreach (var subject in _subjects)
            {
                if (subject.ExamList.Contains(semesterSetting.SemesterNumber)|| subject.CreditList.Contains(semesterSetting.SemesterNumber))
                {
                    if (subject.ExamList.Contains(semesterSetting.SemesterNumber))
                        examCount ++;
                    if (subject.CW != 0)
                        CWCount++;
                    if (subject.CreditList.Contains(semesterSetting.SemesterNumber))
                        creditCount ++;

                    ECTSCount += subject.ECTS / subject.Semesters.Count(s => s.Lectures !=0 || s.LaboratoryWorks !=0 || s.PracticalWorks!=0);
                }
            }

            if (semesterSetting.SemesterNumber < 5)
            {
                coefficient = (135 - (examCount * 18) - (creditCount * 2) - (CWCount * 6)) / ECTSCount;
            }
            else
            {
                coefficient = (135 - (examCount * 18) - (creditCount * 2) - (CWCount * 6)) / ECTSCount;
            }

            return coefficient;
        }
    }
}