using System;

namespace MyApp
{
    class Book
    {

        public string title;
        public string author;
        public string bookId;
        public Book()
        {
            title = "CSS";
            author = "Saira";
            bookId = "001";
        }
        public Book(string title, string author, string bookId)
        {
            this.title = title;
            this.author = author;
            this.bookId = bookId;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {title} \nAuthor: {author} \nBook ID: {bookId}");
        }
    }
    class Person
    {
        /*string name;
        int age;
        string personId;*/
    }
    class Library : Book
    {
        //string name;
        //string libraryId;
        List<Book> bookStore = new List<Book>();
        public void addBook(Book book)
        {
            bookStore.Add(book);
            Console.WriteLine("Book added");
        }
        public void removeBook(string bookId)
        {
            foreach (Book book in bookStore)
            {
                if (book.bookId == bookId)
                {
                    bookStore.Remove(book);
                    Console.WriteLine($"Book removed {bookStore}");
                    return;
                }
            }
            Console.WriteLine($"Book with given ID {bookId} does not exist in library.");
        }
        public void viewBooks()
        {
            Console.WriteLine("View all books available in Library:\n");
            foreach (Book book in bookStore)
            {
                Console.WriteLine($"Title: {book.title} \nAuthor: {book.author} \nBook ID: {book.bookId} \n ----");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Library Management System\n\n");
            Book book1 = new Book();
            Book book2 = new Book("It's life", "William Shakespeare", "002" );
            Book book3 = new Book("Reclaim your heart","Yasmeen Mujahid", "003" );
            Book book4 = new Book("Ric dad, Poor dad","Nelson", "004" );
            Book book5 = new Book(".NET foundation","Anonymous", "005" );
            bool isDone = false;
            while (!isDone)
            {

            }

            /*book1.DisplayInfo();
            Library library = new Library();
            library.addBook(book1);
            library.addBook(book2);
            library.viewBooks();
            library.removeBook("CS-01");
            Console.WriteLine("..........");
            library.viewBooks();*/

        }
    }
}