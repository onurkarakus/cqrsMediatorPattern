using CqrsMediatorPattern.Domain.Enums;

namespace CqrsMediatorPattern.Domain.Entities;

public class Book
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public BookGenre BookGenre { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
}
