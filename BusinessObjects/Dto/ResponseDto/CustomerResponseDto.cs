namespace BusinessObjects.DTO.ResponseDto;

public class CustomerResponseDto
{
    public required string CustomerId { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public int? Point { get; set; }
}