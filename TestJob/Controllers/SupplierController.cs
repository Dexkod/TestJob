using Microsoft.AspNetCore.Mvc;
using TestJob.Services;
using TestJob.ViewModels;

namespace TestJob.Controllers;

[ApiController]
[Route("[controller]")]
public class SupplierController : ControllerBase
{
    readonly ILogger<SupplierController> _logger;
    readonly ISupplierService _supplierService;

    public SupplierController(ILogger<SupplierController> logger, ISupplierService supplierService)
    {
        _logger = logger;
        _supplierService = supplierService;
    }

    /// <summary>
    /// Получение 3 популярных поставщиков
    /// </summary>
    /// <returns></returns>
    [HttpGet("[action]")]
    [ProducesResponseType(typeof(List<SupplierList>), StatusCodes.Status200OK)]
    public IActionResult GetPopularSupplier()
    {
        _logger.LogInformation("Request GetPopilarSupplier");
        return Ok(_supplierService.GetSupplierList());
    }
}
