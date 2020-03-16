using System;
using System.Collections.Generic;

namespace gradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
            sumGrade = 0d;
            highestGrade = double.MinValue;
            LowestGrade = double.MaxValue;
        }
        
        public void AddLetterGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    grades.Add(90);
                    break;

                case 'B':
                    grades.Add(80);
                    break;

                case 'C':
                    grades.Add(70);
                    break;
                
                default:
                    grades.Add(0);
                    break;

            }
        }

        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
                sumGrade += grade;
                highestGrade = Math.Max(grade , highestGrade);
                LowestGrade = Math.Min(grade, LowestGrade);
            }
            else 
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            double averageGrade = sumGrade / grades.Count;
            result.average = averageGrade;
            result.highestNumber = highestGrade;
            result.lowestNumber = LowestGrade;

            switch (averageGrade)
            {
                case var d when d >= 90:
                    result.Letter = 'A';
                    break;

                case var d when d >= 80:
                    result.Letter = 'B';
                    break;

                case var d when d >= 70:
                    result.Letter = 'C';
                    break; 

                case var d when d >= 60:
                    result.Letter = 'D';
                    break;
                
                default:
                    result.Letter = 'F';
                    break;
            }

            return result;
        }

        private List<double> grades;
        public string Name;
        double sumGrade;
        double highestGrade;
        double LowestGrade;
    }
}