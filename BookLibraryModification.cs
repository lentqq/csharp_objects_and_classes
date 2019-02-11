﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;


namespace _06.BookLibraryModification
{
    class BookLibraryModification
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Book> myBooks = new List<Book>();
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                Book book = new Book();
                book.Title = input[0];
                book.Author = input[1];
                book.Publisher = input[2];
                book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.ISBN = input[4];
                book.Price = double.Parse(input[5]);
                myBooks.Add(book);
            }
            DateTime givenDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Library myLibrary = new Library();
            myLibrary.Books = myBooks;

            foreach (var book in myLibrary.Books.Where(x => x.ReleaseDate > givenDate)
                .OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title))
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate.ToString("dd.MM.yyy")}");
            }
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }
    class Library
    {
        public List<Book> Books { get; set; }
        public string Name { get; set; }
    }
}
