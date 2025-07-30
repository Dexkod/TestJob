using TestJob.ViewModels;
using TestJobRepo;

namespace TestJob.Services;

public class SupplierService : ISupplierService
{
    readonly ILogger<SupplierService> _logger;
    readonly Repository _repository;

    public SupplierService(ILogger<SupplierService> logger, Repository repository)
    {
        _logger = logger;
        _repository = repository;
    }

    public List<SupplierList> GetSupplierList()
    {
        var listSupplierIds = _repository.Offers.GroupBy(_ => _.SupplierId)
            .Select(_ => new { SupplierId = _.Key, Count = _.Count() })
            .OrderByDescending(_ => _.Count)
            .Take(3)
            .ToList();

        var supplierList = _repository.Suppliers.Where(_ => listSupplierIds.Any(l => l.SupplierId == _.Id))
            .Select(_ => new SupplierList()
            {
                CountOffers = listSupplierIds.Single(l => l.SupplierId == _.Id).Count,
                Name = _.Name,
            }).ToList();

        _logger.LogInformation("GetSupplierList model @{supplierList}", supplierList);

        return supplierList;
    }
}
