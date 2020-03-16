using System;
using Xunit;

namespace gradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesGrades()
        {   
            //arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //act
            var result = book.GetStatistics();

            //assert
            Assert.Equal(85.6, result.average, 1);
            Assert.Equal(90.5, result.highestNumber, 1);
            Assert.Equal(77.3, result.lowestNumber, 1);

        }
    }
}
