using System;
using System.Net;


namespace MyApp
{
    abstract class Book
    {

        public string title;
        public string author;
        public string bookId;
        public bool isIssued = false;
        public Book()
        {
            title = "CSS";
            author = "Saira";
            bookId = "001";
        }
        public Book(string title, string author, string bookId, bool isIssued = false)
        {
            this.title = title;
            this.author = author;
            this.bookId = bookId;
            this.isIssued = false;
        }
        public abstract void DisplayInfo(Book book);
    }

    class FictionBook : Book
    {
        public FictionBook() { }
        public FictionBook(string title, string author, string bookId, bool isIssued = false) : base(title, author, bookId) { }
        public override void DisplayInfo(Book book)
        {
            Console.WriteLine($"Fiction Book \nTitle: {book.title} \nAuthor: {book.author} \nBook ID: {book.bookId} \nStatus: {book.isIssued}");
        }
    }

    class NonFictionBook : Book
    {
        public NonFictionBook() { }
        public NonFictionBook(string title, string author, string bookId, bool isIssued) : base(title, author, bookId, isIssued = false) { }
        public override void DisplayInfo(Book book)
        {
            Console.WriteLine($"Non-FictionY Book \nTitle: {book.title} \nAuthor: {book.author} \nBook ID: {book.bookId} \nStatus: {book.isIssued}");
        }
    }

    class Person
    {
        public string name;
        public int age;
        public string personId;
        public List<Book> books;
        public Person() { }
        public Person(string name, int age, string personId)
        {
            this.name = name;
            this.age = age;
            this.personId = personId;
            this.books = new List<Book>();
        }
        public void userInfo(Person user)
        {
            Console.WriteLine($"Name: {user.name} \nAge: {user.age} \nID: {user.personId}");
        }
    }
    class Librarian : Person
    {
        string employeeId;
        public Librarian(string name, int age, string personId) : base(name, age, personId ) { }
        public Librarian(string name, int age, string personId, string employeeId)
        {
            this.employeeId = employeeId;
        }
        public void userInfo(Librarian user)
        {
            Console.WriteLine($"Name: {user.name} \nAge: {user.age} \nID: {user.personId} \nEmployee ID: {user.employeeId}");
        }
        public void issueBook(Book book, Person user)
        {
            if (book.isIssued)
            {
                Console.WriteLine("Book is not avaiable.Already issued to some other reader");
            }
            else
            {
                book.isIssued = true;
                user.books.Add(book);
                Console.WriteLine("Book is issued to you.");

            }
        }
        public void returnBook(Book book, Person user)
        {
            if (user.books.Contains(book))
            {
                book.isIssued = false;
                user.books.Remove(book);
                Console.WriteLine($"Book {book.title} returned");
                return;
            }
            else
            {
                Console.WriteLine($"Book {book.title} is not issued to reader {user.personId}");
                return;
            }
        }
    }


    class Library
    {
        string name;
        string libraryId;
        List<FictionBook> fictionBookStore = new List<FictionBook>();
        List<NonFictionBook> nonFictionBookStore = new List<NonFictionBook>();
        List<Person> personStore = new List<Person>();
        public Librarian librarian;
        public Library(string name = "Library", string libraryId = "1")
        {
            this.name = name;
            this.libraryId = libraryId;
        }
        public void addReader(Person reader)
        {
            personStore.Add(reader);
            Console.WriteLine("Reader added");
        }
        public void addFictionBook(FictionBook book)
        {
            fictionBookStore.Add(book);
            Console.WriteLine(" Fiction Book added");
        }
        public void addNonFictionBook(NonFictionBook book)
        {
            nonFictionBookStore.Add(book);
            Console.WriteLine("Non-Fiction Book added");
        }
        public Book getBook(string bookTitle)
        {
            foreach (FictionBook book in fictionBookStore)
            {
                if (book.title == bookTitle)
                {
                    return book;
                }
            }
            foreach (NonFictionBook book in nonFictionBookStore)
            {
                if (book.title == bookTitle)
                {
                    return book;
                }
            }
            Console.WriteLine($"Book {bookTitle} does not exist");
            return null;
        }
        public void removeBook(string bookId)
        {
            bool isRemoved = false;
            foreach (FictionBook book in fictionBookStore)
            {
                if (book.bookId == bookId)
                {
                    fictionBookStore.Remove(book);
                    Console.WriteLine($"Book removed");
                    return;
                }
            }
            foreach (NonFictionBook book in nonFictionBookStore)
            {
                if (book.bookId == bookId)
                {
                    nonFictionBookStore.Remove(book);
                    Console.WriteLine($"Book removed");
                    return;
                }
            }
            Console.WriteLine($"Book with given ID {bookId} does not exist in library.");
        }
        public void viewBooks()
        {
            Console.WriteLine("View all books available in Library:\n");
            foreach (FictionBook book in fictionBookStore)
            {
                book.DisplayInfo(book);
            }
            foreach (NonFictionBook book in nonFictionBookStore)
            {
                book.DisplayInfo(book);
            }
        }
        public void searchBook(string title)
        {
            foreach (FictionBook book in fictionBookStore)
            {
                if (book.title == title)
                {
                    Console.WriteLine($"Book is available: ");
                    book.DisplayInfo(book);
                    return;
                }
            }
            foreach (NonFictionBook book in nonFictionBookStore)
            {
                if (book.title == title)
                {
                    Console.WriteLine($"Book is available: ");
                    book.DisplayInfo(book);
                    return;
                }
            }
            Console.WriteLine($"Book with title \'{title}\' does not exist.");
        }
        public void listIssuedBooks()
        {
            foreach (FictionBook book in fictionBookStore)
            {
                if (book.isIssued == true)
                {
                    book.DisplayInfo(book);
                }
            }
            foreach (NonFictionBook book in nonFictionBookStore)
            {
                if (book.isIssued == true)
                {
                    book.DisplayInfo(book);
                }
            }
            return;
        }
        public Person searchReader(string id)
        {
            foreach (Person person in personStore)
            {
                if (person.personId == id)
                {
                    return person;
                }
            }
            Console.WriteLine($"Reader {id} does not exist");
            return null;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Library Management System\n\n");

            FictionBook book1 = new FictionBook();
            NonFictionBook book2 = new NonFictionBook("It's life", "William Shakespeare", "002", false );
            NonFictionBook book3 = new NonFictionBook("Reclaim your heart","Yasmeen Mujahid", "003", false );
            FictionBook book4 = new FictionBook("Rich dad, Poor dad","Nelson", "004", false );
            FictionBook book5 = new FictionBook("It's a life","Anonymous", "005", false );
            Library library = new Library();
            library.librarian = new Librarian("John", 35, "06", "L1");
            library.addFictionBook(book1);
            library.addNonFictionBook(book2);
            library.addNonFictionBook(book3);
            library.addFictionBook(book4);
            library.addFictionBook(book5);
            Person person = new Person("Saira", 25, "01");
            Person person1 = new Person("Maha", 20, "02");
            Person person2 = new Person("Fatima", 35, "03");
            Person person3 = new Person("Minal", 25, "04");
            library.addReader(person);
            library.addReader(person1);
            library.addReader(person2);
            library.addReader(person3);
            bool isDone = true;
            while (isDone)
            {
                Console.WriteLine("What do you want to do?" +
                "\n 1.Add Book" +
                "\n 2.View Books" +
                "\n 3.Remove Book" +
                "\n 4.Search Book" +
                "\n 5.List issued Books" +
                "\n 6.Issue Book" +
                "\n 7.Return Book");
                int task = int.Parse(Console.ReadLine());
                switch (task)
                {
                    case 1:
                        Console.WriteLine("Which type of book do you want to add? \n1.Fiction\n2.NonFiction");
                        int choice = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter title of the Book:");
                        string bookTitle = Console.ReadLine();
                        Console.WriteLine("Enter author of the Book:");
                        string bookAuthor = Console.ReadLine();
                        Console.WriteLine("Enter book ID:");
                        string bookId = Console.ReadLine();
                        if (choice == 1)
                        {
                            FictionBook book = new FictionBook(bookTitle, bookAuthor, bookId, false);
                            library.addFictionBook(book);
                        }
                        else if (choice == 2)
                        {
                            NonFictionBook book = new NonFictionBook(bookTitle, bookAuthor, bookId, false);
                            library.addNonFictionBook(book);
                        }
                        else
                        {
                            Console.WriteLine("Invalid option selected.");
                        }
                        break;
                    case 2:
                        library.viewBooks();
                        break;
                    case 3:
                        Console.WriteLine("Enter book ID to remove a book: ");
                        string Id = Console.ReadLine();
                        library.removeBook(Id);
                        break;
                    case 4:
                        Console.WriteLine("Enter title of the book you want to search: ");
                        string title = Console.ReadLine();
                        library.searchBook(title);
                        break;
                    case 5:
                        library.listIssuedBooks();
                        break;
                    case 6:
                        Console.WriteLine("Enter your ID: ");
                        string userId = Console.ReadLine();
                        Person user = library.searchReader(userId);
                        if ( user != null)
                        {
                            Console.WriteLine("Enter title of the book you want: ");
                            string titleOfBook = Console.ReadLine();
                            Book book = library.getBook(titleOfBook);
                            if(book != null)
                                library.librarian.issueBook(book, user);

                        } 
                        break;
                    case 7:
                        Console.WriteLine("Enter your ID: ");
                        string id = Console.ReadLine();
                        Person reader = library.searchReader(id);
                        if (reader != null)
                        {
                            Console.WriteLine("Enter title of the book you want: ");
                            string titleOfBook = Console.ReadLine();
                            Book book = library.getBook(titleOfBook);
                            if (book != null)
                                library.librarian.returnBook(book, reader);

                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Option Selected.Please Try Again with correct option.");
                        break;
                }
                Console.WriteLine("Do you want to continue?(Y/N): ");
                char option = Convert.ToChar(Console.ReadLine());
                if (option == 'Y')
                    isDone = true;
                else if (option == 'N')
                {
                    isDone = false;
                    Console.WriteLine("Have a nice day!");
                }
                else
                    Console.WriteLine("Invalid Option Selected.");
                isDone = false; 
            }

        }
    }
}