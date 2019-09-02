using System.Net.Http;
using Xunit;
using System.Net;
using System.Threading.Tasks;

namespace Softplan.Calc.IntegrationTests
{
    public class AboutControllerTests
    {
        private readonly ApiTestContext _context;
        public AboutControllerTests()
        {
            _context = new ApiTestContext();
        }

        [Theory]
        [InlineData("GET")]
        public async Task Shoud_return_github_address(string method)
        {
            var request = new HttpRequestMessage(new HttpMethod(method), "showmethecode");

            var response = await _context.Client.SendAsync(request);

            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.StartsWith("https://github.com/", response.Content.ReadAsStringAsync().Result);
        }
    }
}