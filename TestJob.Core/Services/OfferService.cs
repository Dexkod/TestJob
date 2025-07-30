using Microsoft.Extensions.Logging;
using TestJobRepo;

namespace TestJob.Core.Services;

public class OfferService
{
    readonly ILogger<OfferService> _logger;
    readonly Repository _repository;

    public OfferService(ILogger<OfferService> logger, Repository repository)
    {
        
    }
}
