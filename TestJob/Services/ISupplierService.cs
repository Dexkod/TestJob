using TestJob.ViewModels;

namespace TestJob.Services;

public interface ISupplierService
{
    List<SupplierList> GetSupplierList();
}
