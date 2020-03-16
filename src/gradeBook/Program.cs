using System;
using System.Collections.Generic;

namespace gradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("clock's books"); 
            Console.WriteLine("Please enter the number!");

            while (true)
            {
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
            Console.WriteLine($"Average Grade is: {stats.average:N2}");
            Console.WriteLine($"Highest Grade is: {stats.highestNumber:N2}");
            Console.WriteLine($"Lowest Grade is: {stats.lowestNumber:N2}");
            Console.WriteLine($"Letter Grade is: {stats.Letter}");


        }
    }
}
