using CqrsMediatorPattern.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CqrsMediatorPattern.Data.Context;

public class BookDbContext : DbContext
{
    public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
    {

    }

    public DbSet<Book> Books { get; set; }
}
