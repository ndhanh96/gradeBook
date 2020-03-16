using System;
using System.Collections.Generic;

namespace gradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("clock's books"); 
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            var stats = book.GetStatistics();
            Console.WriteLine($"Average Grade is: {stats.average:N2}");
            Console.WriteLine($"Highest Grade is: {stats.highestNumber:N2}");
            Console.WriteLine($"Lowest Grade is: {stats.lowestNumber:N2}");


        }
    }
}
