using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using IT3045_Final.Data;
using IT3045_Final.Interfaces;
using IT3045_Final.Models;

namespace IT3045_Final.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookContextDAO _contextDAO;

        public BooksController(IBookContextDAO contextDAO)
        {
            _contextDAO = contextDAO ?? throw new ArgumentNullException(nameof(contextDAO));
        }

        [HttpGet]
        public IActionResult Get()
        {
            var books = _contextDAO.GetAllBooks();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var book = _contextDAO.GetBookById(id);
            if (book == null)
                return NotFound(id);

            return Ok(book);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = _contextDAO.RemoveBookById(id);
            if (book == null)
                return NotFound(id);

            return Ok(book);
        }

        [HttpPut]
        public IActionResult Put(int id, Book updatedBook)
        {
            var existingBook = _contextDAO.GetBookById(id);
            if (existingBook == null)
                return NotFound(id);

            var updated = _contextDAO.UpdateBook(updatedBook);
            if (updated == null)
                return NotFound(updatedBook);

            return Ok(updated);
        }

        [HttpPost]
        public IActionResult Post(Book newBook)
        {
            var addedBook = _contextDAO.AddBook(newBook);

            if (addedBook == null)
                return StatusCode(500, "Book Already Exists");

            return Ok(addedBook);
        }
    }
}

