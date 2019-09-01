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