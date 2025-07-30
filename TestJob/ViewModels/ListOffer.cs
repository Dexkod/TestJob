namespace TestJob.ViewModels;

public class ListOffer
{
    public int Total { get; set; }
    public List<GetOffer> Offers { get; set; } = null!;
}
