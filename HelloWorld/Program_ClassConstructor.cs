using System;

namespace ClassConstructor
{
    class Book//1. WE're going to create a template for making specific books
    {
        private int pageCount;//2. Instance variable is private, this means only the Book class can change it
                              //3. As with variables in general, pageCount has a definite data type
                              //4. Its value does not to be set here because we will set it within the constructor
                              //5. pageCount can change from book object to book object
        public Book(int pgCount)
        {
            pageCount = pgCount;//6. When a specific book is made, pageCount is set equal to pgCount
        }
    }
    class Program
    {
        //static void Main()
        //{
        //    Book myBook = new Book(400);//7. Creates a new book object. This book happens to have 400 pages. 
        //    Book mySecondBook = new Book(500);//8. Creates another book object. 
        //}
    }
}