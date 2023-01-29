namespace CqrsMediatorPattern.CQRS.Commands.Response;

/// <summary>
/// Delete Book Command Response Model
/// </summary>
public class DeleteBookCommandResponse
{
    /// <summary>Gets or sets a value indicating whether this instance is success.</summary>
    /// <value><c>true</c> if this instance is success; otherwise, <c>false</c>.</value>
    public bool IsSuccess { get; set; }
}
