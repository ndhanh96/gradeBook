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
            var result = new Statistics();
            highestGrade = double.MinValue;
            LowestGrade = double.MaxValue;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
            sumGrade += grade;
            highestGrade = Math.Max(grade , highestGrade);
            LowestGrade = Math.Min(grade, LowestGrade);
        
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            double averageGrade = sumGrade / grades.Count;
            // Console.WriteLine($"Average Grade is: {averageGrade:N2}");
            // Console.WriteLine($"Highest Grade is: {highestGrade:N2}");
            // Console.WriteLine($"Lowest Grade is: {LowestGrade:N2}");
            result.average = averageGrade;
            result.highestNumber = highestGrade;
            result.lowestNumber = LowestGrade;
            

            return result;
        }

        private List<double> grades;
        public string Name;
        double sumGrade;
        double highestGrade;
        double LowestGrade;
    }
}