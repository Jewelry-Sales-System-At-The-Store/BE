namespace BusinessObjects.DTO;

public class UpdateCounter
{
    public int? Number { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}