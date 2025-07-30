using TestJob.ViewModels;

namespace TestJob.Services;

public interface IOfferService
{
    int Save(CreateOffer offer);
    ListOffer Find(FilterOffer filter);
}
