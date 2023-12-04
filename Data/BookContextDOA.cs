

using System.Collections.Generic;
using IT3045_Final.Interfaces;
using IT3045_Final.Models;

namespace IT3045_Final.Data
{
    public class BookContextDAO : IBookContextDAO
    {
        private BookContext _context;

        public BookContextDAO(BookContext context)
        {
            _context = context;
        }

        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            return _context.Books.Find(id);
        }

        public Book RemoveBookById(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null)
                return null;

            _context.Books.Remove(book);
            return book;
        }

        public Book UpdateBook(Book updatedBook)
        {
            var bookToUpdate = _context.Books.Find(updatedBook.Id);
            if (bookToUpdate == null)
                return null;

            if (!string.IsNullOrEmpty(updatedBook.Title))
                bookToUpdate.Title = updatedBook.Title;
            if (!string.IsNullOrEmpty(updatedBook.Author))
                bookToUpdate.Author = updatedBook.Author;
            if (!string.IsNullOrEmpty(updatedBook.Genre))
                bookToUpdate.Genre = updatedBook.Genre;

            try
            {
                _context.Books.Update(bookToUpdate);
                _context.SaveChanges();
                return bookToUpdate;
            }
            catch (Exception)
            {
                // Handle exception
                return null;
            }
        }

        public Book AddBook(Book newBook)
        {
            var existingBook = _context.Books.FirstOrDefault(b => b.Title == newBook.Title && b.Author == newBook.Author);
            if (existingBook != null)
                return null; // Book already exists

            try
            {
                var bookToAdd = new Book
                {
                    Title = newBook.Title,
                    Author = newBook.Author,
                    Genre = newBook.Genre,
                    PublicationYear = newBook.PublicationYear
                };

                _context.Books.Add(bookToAdd);
                _context.SaveChanges();
                return bookToAdd;
            }
            catch (Exception)
            {
                // Handle exception
                return null;
            }
        }
    }
}


