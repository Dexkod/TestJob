using TestJobRepo.Models;

namespace TestJob.ViewModels;

public class GetOffer
{
    public int Id { get; set; }
    public string Stamp { get; set; } = null!;
    public string Model { get; set; } = null!;
    public Supplier Supplier { get; set; } = null!;
    public DateTime RegistrationDate { get; set; }
}
