using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using UrlShortener.Controllers;
using UrlShortener.Dtos;
using Xunit;

namespace UrlShortener.Tests
{
    public class unittests
    {

        [Fact]
        public void EncodeUrl()
        {
            UrlShorteningService shorteningService = new UrlShorteningService();
            var input = new UrlDto { Url = "https://www.linkedin.com/in/dominique-burke/" };
            var response = shorteningService.Encode(input.Url);
            Assert.NotNull(response);
        }

        [Fact]
        public void DecodeUrl()
        {
            UrlShorteningService shorteningService = new UrlShorteningService();
            var input = new UrlDto { Url = "https://www.linkedin.com/in/dominique-burke/" };
            var response = shorteningService.Encode(input.Url);
            Assert.NotNull(response);
            var decodedUrl = shorteningService.Decode(response);
            Assert.NotNull(decodedUrl);
            Assert.Equal(input.Url , decodedUrl);
        }
    }
}
