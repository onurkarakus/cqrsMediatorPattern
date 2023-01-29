using CqrsMediatorPattern.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CqrsMediatorPattern.Data.Context;

/// <summary>
/// Book DbContext Model
/// </summary>
public class BookDbContext : DbContext
{
    /// <summary>Initializes a new instance of the <see cref="BookDbContext" /> class.</summary>
    /// <param name="options">The options.</param>
    public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
    {

    }

    /// <summary>Gets or sets the books.</summary>
    /// <value>The books.</value>
    public DbSet<Book> Books { get; set; }
}
