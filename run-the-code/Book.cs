using System;

namespace CSharp// <-class. namespace harus sama sama yang di Program.cs
{
    class Book
    {
        public string title = "";
        public string author = "";
        public int pages;
    }
    class BookConst // better using this with constructor
    {
        public BookConst(string aTitle, string aAuthor, int aPages) //<-- this is constructor
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
        public string title = "";
        public string author = "";
        public int pages;
    }
}