using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UrlShortener.Dtos;

namespace UrlShortener.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DecodeController : ControllerBase
    {
        private readonly ILogger<DecodeController> _logger;

        public DecodeController(ILogger<DecodeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public UrlDto Decode(ShortenedUrlDto request) => throw new System.NotImplementedException();
    }
}
