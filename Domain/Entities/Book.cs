using CqrsMediatorPattern.Domain.Enums;

namespace CqrsMediatorPattern.Domain.Entities;

/// <summary>
/// Book Model
/// </summary>
public class Book
{
    /// <summary>Gets or sets the identifier.</summary>
    /// <value>The identifier.</value>
    public long Id { get; set; }

    /// <summary>Gets or sets the title.</summary>
    /// <value>The title.</value>
    public string? Title { get; set; }

    /// <summary>Gets or sets the description.</summary>
    /// <value>The description.</value>
    public string? Description { get; set; }

    /// <summary>Gets or sets the book genre.</summary>
    /// <value>The book genre.</value>
    public BookGenre BookGenre { get; set; }

    /// <summary>Gets or sets the created.</summary>
    /// <value>The created.</value>
    public DateTime Created { get; set; }

    /// <summary>Gets or sets the updated.</summary>
    /// <value>The updated.</value>
    public DateTime Updated { get; set; }
}
