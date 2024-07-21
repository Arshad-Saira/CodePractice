using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.BusinessLayer;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookBL bookBL = new BookBL();

        // GET: api/Books
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            var books = bookBL.GetBooks();
            return Ok(books);
        }

        // GET: api/Books/1
        [HttpGet("{id}/books")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = bookBL.GetBook(id);

            if (book == null)
            {
                return NotFound(new { Message = "Book not found" });
            }

            return Ok(book);
        }

        // POST: api/Books
        [HttpPost]
        public ActionResult<Book> PostBook(Book book)
        {
            bookBL.AddBook(book);
            //return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
            return Ok(book);
        }

        // PUT: api/Books/2
        [HttpPut("{id}")]
        public IActionResult PutBook(int id, Book book)
        {
            var existingBook = bookBL.GetBook(id);
            if (existingBook == null)
            {
                return NotFound(new { Message = "Book not found" });
            }

            bookBL.UpdateBook(id, book);
            return Ok(new { Message = "Book updated successfully" });
        }

        // DELETE: api/Books/1
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var existingBook = bookBL.GetBook(id);
            if (existingBook == null)
            {
                return NotFound(new { Message = "Book not found" });
            }

            bookBL.DeleteBook(id);
            return Ok(new { Message = "Book deleted successfully" });
        }
    }
}
