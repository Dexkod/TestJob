using System.ComponentModel.DataAnnotations;

namespace TestJob.ViewModels;

public record CreateOffer
{
    [Required]
    public string Stamp { get; set; } = null!;
    [Required]
    public string Model { get; set; } = null!;
    [Required]
    public string SupplierName { get; set; } = null!;
    [Required]
    public DateTime RegistrationDate { get; set; }
}
