using System;


namespace CSharp
{
    class Program
    {
        static void Main() // yang main itu yang di utamakan si program
        {
            // create a new book
            //Object       -\/-     
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "J.K. Rowling";
            book1.pages = 400;

            // create another book with constructor
            BookConst book2 = new BookConst("Lord of the Rings", "J.R.R. Tolkien", 700);
            book2.title = "The Hobbit";

            // print out the books
            Console.WriteLine(book2.longBook());
            Console.WriteLine("The book is {0} by {1} and has {2} pages", book1.title, book1.author, book1.pages);
            Console.WriteLine("The book is {0} by {1} and has {2} pages", book2.title, book2.author, book2.pages);
        }
    }
}