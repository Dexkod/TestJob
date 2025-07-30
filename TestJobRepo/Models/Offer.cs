namespace TestJobRepo.Models;

public record Offer : BaseEntity
{
    public string Stamp { get; set; } = null!;
    public string Model { get; set; } = null!;
    public int SupplierId { get; set; }
    public Supplier Supplier { get; set; } = null!;
    public DateTime RegistrationDate { get; set; }
}
