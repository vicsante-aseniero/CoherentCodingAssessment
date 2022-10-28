using BooksAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.DataAccess
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions options) : base(options) { }

        public DbSet<Book> Book { get; set; } = null!;
    }
}