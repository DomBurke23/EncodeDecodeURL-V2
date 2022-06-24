using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UrlShortener.Dtos;

namespace UrlShortener.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EncodeController : ControllerBase
    {
        private readonly ILogger<EncodeController> _logger;

        public EncodeController(ILogger<EncodeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ShortenedUrlDto Encode(UrlDto request)
        {
            //var shortUrl = _urlShorteningService.Encode(request.Url);
            //return shortUrl;
            return null;
        }
    }
}
