using LinqKit;
using TestJob.ViewModels;
using TestJobRepo;
using TestJobRepo.Models;

namespace TestJob.Services;

public class OfferService : IOfferService
{
    readonly ILogger<OfferService> _logger;
    readonly Repository _repository;

    public OfferService(ILogger<OfferService> logger, Repository repository)
    {
        _repository = repository;
        _logger = logger;
    }

    public int Save(CreateOffer offer)
    {

        var newSupplier = new Supplier()
        {
            Name = offer.SupplierName,
            CreatedAt = DateTime.UtcNow,
        };
        var newSupplierId = _repository.Save(newSupplier);
        newSupplier.Id = newSupplierId;
        _logger.LogInformation("Create Supplier @{model}", newSupplier);

        var newOffer = new Offer()
        {
            Model = offer.Model,
            Stamp = offer.Stamp,
            Supplier = newSupplier,
            SupplierId = newSupplierId,
            RegistrationDate = offer.RegistrationDate
        };
        var newOfferId = _repository.Save(newOffer);
        newOffer.Id = newOfferId;
        _logger.LogInformation("Create Offer @{model}", newOffer);

        return newOfferId;
    }

    public ListOffer Find(FilterOffer filter)
    {
        var predicate = PredicateBuilder.New<Offer>(true);

        if (!string.IsNullOrWhiteSpace(filter.Model))
        {
            predicate.And(_ => _.Model.Contains(filter.Model));
        }

        if (!string.IsNullOrWhiteSpace(filter.Stamp))
        {
            predicate.And(_ => _.Stamp.Contains(filter.Stamp));
        }

        if (filter.SupplierId.HasValue)
        {
            predicate.And(_ => _.SupplierId == filter.SupplierId);
        }

        var offers = _repository.Offers.Where(predicate).Select(_ => new GetOffer()
        {
            Id = _.Id,
            Supplier = _.Supplier,
            Stamp = _.Stamp,
            Model = _.Model,
            RegistrationDate = _.RegistrationDate
        }).ToList();

        var listOffers = new ListOffer()
        {
            Total = offers.Count,
            Offers = offers
        };

        _logger.LogInformation("Find listOffers model: @{model}", listOffers);
        
        return listOffers;
    }
}
