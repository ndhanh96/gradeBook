using System;
using Xunit;

namespace gradeBook.Tests
{
    public class TypeTest
    {
        [Fact]
        public void Test1()
        {   
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");
            
            Assert.Equal("Book 1", book1.Name);
            
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {   
            var book1 = GetBook("Book 1");
            setName(book1, "New Name");
            
            Assert.Equal("New Name", book1.Name);
            
        }

        private void setName(Book book, string name)
        {
            book.Name = name;
        }


        [Fact]
        public void GetBookReturnsDifferentObjects()
        {   
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
            
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            
        }

        Book GetBook(string name)
        {
            return new Book(name);

        }
    }
}
