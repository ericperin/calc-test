using System.Net.Http;
using Xunit;
using System.Net;
using System.Threading.Tasks;

namespace Softplan.Calc.IntegrationTests
{
    public class TaxaJurosControllerTests
    {
        private readonly ApiTestContext _context;
        public TaxaJurosControllerTests()
        {
            _context = new ApiTestContext();
        }


        [Fact]
        public async Task Values_GetById_CorrectContentType()
        {
            var response = await _context.Client.GetAsync("taxajuros");
            response.EnsureSuccessStatusCode();

            Assert.Equal("application/json; charset=utf-8", response.Content.Headers.ContentType.ToString());
        }

        [Theory]
        [InlineData("GET")]
        public async Task GetJuros(string method)
        {
            var request = new HttpRequestMessage(new HttpMethod(method), "taxajuros");

            var response = await _context.Client.SendAsync(request);

            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}