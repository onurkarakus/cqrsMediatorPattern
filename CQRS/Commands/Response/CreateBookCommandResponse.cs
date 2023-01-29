namespace CqrsMediatorPattern.CQRS.Commands.Response;

/// <summary>
/// Create Book Command Response Model
/// </summary>
public class CreateBookCommandResponse
{
    /// <summary>Gets or sets a value indicating whether this instance is success.</summary>
    /// <value><c>true</c> if this instance is success; otherwise, <c>false</c>.</value>
    public bool IsSuccess { get; set; }

    /// <summary>Gets or sets the created book identifier.</summary>
    /// <value>The created book identifier.</value>
    public int CreatedBookId { get; set; }
}
