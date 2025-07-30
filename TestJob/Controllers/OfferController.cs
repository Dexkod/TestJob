using Microsoft.AspNetCore.Mvc;
using TestJob.Services;
using TestJob.ViewModels;
using TestJobRepo;
using TestJobRepo.Models;

namespace TestJob.Controllers;

[ApiController]
[Route("[controller]")]
public class OfferController : ControllerBase
{
    readonly ILogger<OfferController> _logger;
    readonly IOfferService _offerService;

    public OfferController(ILogger<OfferController> logger, IOfferService offerService)
    {
        _logger = logger;
        _offerService = offerService;
    }

    /// <summary>
    /// Создания оффера
    /// </summary>
    /// <param name="offer">Оффер</param>
    /// <returns>Идентификатор нового офера</returns>
    [HttpPost("[action]")]
    [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
    public IActionResult Create(CreateOffer offer)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        _logger.LogInformation("Request Create model: @{offer}", offer);

        return Ok(_offerService.Save(offer));
    }

    /// <summary>
    /// Получение офферов
    /// </summary>
    /// <param name="filter">Фильтрации</param>
    /// <returns>Офферы</returns>
    [HttpGet("[action]")]
    [ProducesResponseType(typeof(ListOffer), StatusCodes.Status200OK)]
    public IActionResult Find([FromQuery] FilterOffer filter)
    {
        _logger.LogInformation("Request find model: @{offer}", filter);

        return Ok(_offerService.Find(filter));
    }
}
