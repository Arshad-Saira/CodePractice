using WebApplication1.Models;

namespace WebApplication1.DataAccessLayer
{
    public class BookDAL
    {
        private static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "Reclaim Your Heart", Author = "Yasmin Mogahed", Description = "Its Great Book" , ImageUrl = "/"}
        };

        public List<Book> GetBooks()
        {
            return books;
        }

        public Book GetBook(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }
        public void AddBook(Book book)
        {
            book.Id = books.Max(p => p.Id) + 1;
            books.Add(book);
        }

        public void UpdateBook(Book book)
        {
            var existingBook = books.FirstOrDefault(b => b.Id == book.Id);

            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.Description = book.Description;
                existingBook.ImageUrl = book.ImageUrl;
            }
        }
        public void DeleteBook(int id)
        {
            var book = books.First(b => b.Id == id);
            if (book != null)
            {
                books.Remove(book);
            }
        }
    }
}