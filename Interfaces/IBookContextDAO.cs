

using System.Collections.Generic;
using IT3045_Final.Models;

namespace IT3045_Final.Interfaces
{
    public interface IBookContextDAO
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        Book RemoveBookById(int id);
        Book AddBook(Book book);
        Book UpdateBook(Book book);
    }
}

