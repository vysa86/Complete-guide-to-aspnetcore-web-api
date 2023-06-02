using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_Books.Data;
using My_Books.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private BookService bookService;
        public BookController(BookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody]BookVM book)
        {
            bookService.AddBook(book);
            return Ok();
        }
        [HttpGet("get-all-books")]
        public IActionResult GetAllBooks()
        {
            var allBooks = bookService.GetAllBooks();
            return Ok(allBooks);
        }
        [HttpGet("get-book-by-id/{id}")]
        public IActionResult GetBookByID(int id)
        {
            var book = bookService.GetBookById(id);
            return Ok(book);
        }
        [HttpPut("Update-book-by-id/{id}")]
        public IActionResult UpdateBookByID(int id, [FromBody] BookVM book)
        {
            var updateBook = bookService.UpdateBookById(id, book);
            return Ok(updateBook);
        }

        [HttpDelete("delete-book-by-id/{id}")]
        public IActionResult DeleteBookByID(int id)
        {
             bookService.DeleteBookById(id);
            return Ok();
        }
    }
}
