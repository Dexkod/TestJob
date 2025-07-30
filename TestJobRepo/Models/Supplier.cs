namespace TestJobRepo.Models;

public record Supplier : BaseEntity
{
    public string Name { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
}
