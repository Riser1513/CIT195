using System;
using System.ComponentModel.DataAnnotations;

namespace bookStore
{
    class myStore
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();

            book1.SetTransactions();

            book1.SetId(5690);
            book1.SetAuthor("Mango Juice");
            book1.SetTitle("Squirtle is Himself");

            Book book2 = new Book();

            book2.SetTransactions();

            Console.WriteLine("Please enter a Book ID number: ");
            book2.SetId(int.Parse(Console.ReadLine()));

            Console.WriteLine("Please enter a Book Name: ");
            book2.SetTitle(Console.ReadLine());

            Console.WriteLine("Please enter a Book Author: ");
            book2.SetAuthor(Console.ReadLine());

            Console.WriteLine();

            Book book3 = new Book(9840, "Chaquerie", "A Random Gal");

            book3.SetTransactions();

            Console.WriteLine("Please enter a Book ID number: ");
            int tempId = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a Book Name: ");
            string tempTitle = Console.ReadLine();

            Console.WriteLine("Please enter a Book Author: ");
            string tempAuthor = Console.ReadLine();

            Book book4 = new Book(tempId, tempTitle, tempAuthor);

            book4.SetTransactions();

            Console.WriteLine();

            Console.WriteLine($"The bookstore has {book1.GetTransactions()} books.");

            displayBooks(book1);

            displayBooks(book2);

            displayBooks(book3);

            displayBooks(book4);
        }

        public static void displayBooks(Book book)
        {
            Console.WriteLine("Here's a book's information: ");
            Console.WriteLine($"ID Number: {book.GetId()}");
            Console.WriteLine($"Title: {book.GetTitle()}");
            Console.WriteLine($"Author: {book.GetAuthor()}");
            Console.WriteLine();
        }
    }

    class Book
    {
        private int _Id;
        private string _Title;
        private string _Author;
        private static int _Transactions = 0;
        public Book()
        {
            _Id = 79;
            _Title = "McDonald's Training Manual";
            _Author = "Some Guy";
        }
        public Book(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }

        public int GetId()
        {
            return _Id;
        }

        public void SetId(int id)
        {
            _Id = id;
        }

        public string GetTitle()
        {
            return _Title;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        public string GetAuthor()
        {
            return _Author;
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }

        public int GetTransactions()
        {
            return _Transactions;
        }

        public void SetTransactions()
        {
            _Transactions += 1;
        }
    }
}
