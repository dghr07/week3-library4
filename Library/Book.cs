using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        public string Title;
        public string Author;
        public int ISBN;

        // Parameterised constructor
        public Book(string bookTitle, string bookAuthor, int bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
        }
    }
    
}
