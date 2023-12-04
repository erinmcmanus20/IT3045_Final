
using IT3045_Final.Models;
using Microsoft.EntityFrameworkCore;

namespace IT3045_Final.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Classic", PublicationYear = 1925 },
                new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Fiction", PublicationYear = 1960 },
                new Book { Id = 3, Title = "1984", Author = "George Orwell", Genre = "Dystopian", PublicationYear = 1949 },
                new Book { Id = 4, Title = "The Hitchhiker's Guide to the Galaxy", Author = "Douglas Adams", Genre = "Science Fiction", PublicationYear = 1979 },
                new Book { Id = 5, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Genre = "Coming of Age", PublicationYear = 1951 }
            );
        }

        public DbSet<Book> Books { get; set; }
    }
}
