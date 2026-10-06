using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        // Private Fields
        private string _title;
        private string _author;
        private int _isbn;

        // Public Properties
        public string Title
        {
            get { return _title; }
            set 
            {  
                // Check if any incoming char is a digit
                if (!value.Any(char.IsDigit))
                {
                    _title = value;
                } 
                else
                {
                    Console.WriteLine("Title cannot contain numbers. Please enter a valid title.");
                }

            }
        }
        public string Author
        {
            get { return _author; }
            set 
            {
                if (!value.Any(char.IsDigit))
                {
                    _title = value;
                }
                else
                {
                    Console.WriteLine("Author name cannot contain numbers. Please enter a valid title.");
                }
            }
        }
        public int ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        // Constructor
        public Book(string bookTitle, string bookAuthor, int bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }
        // Methods
        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
        }
    }
    
}
