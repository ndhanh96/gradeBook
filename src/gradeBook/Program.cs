using System;
using System.Collections.Generic;

namespace gradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("clock's books"); 
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded -= OnGradeAdded;
            book.GradeAdded += OnGradeAdded;
            
            while (true)
            {
                Console.WriteLine("Please enter the number!");
                var input = Console.ReadLine();

                if(input.ToUpper() == "Q")
                {  
                    break;
                }

                try
                {
                    book.AddGrade(double.Parse(input));
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine(ex.Message);
                }
                
            }

            var stats = book.GetStatistics();
            Console.WriteLine($"For the book named: {book.Name}");
            Console.WriteLine($"Average Grade is: {stats.average:N2}");
            Console.WriteLine($"Highest Grade is: {stats.highestNumber:N2}");
            Console.WriteLine($"Lowest Grade is: {stats.lowestNumber:N2}");
            Console.WriteLine($"Letter Grade is: {stats.Letter}");

        }

        static void OnGradeAdded(object sender, EventArgs a)
        {
            Console.WriteLine("A grade was added");
        }

    }
}
