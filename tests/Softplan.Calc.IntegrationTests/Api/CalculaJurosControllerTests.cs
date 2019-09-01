using System.Net.Http;
using Xunit;
using System.Net;
using System.Threading.Tasks;

namespace Softplan.Calc.IntegrationTests
{
    public class CalculaJurosControllerTests
    {
        private readonly ApiTestContext _context;
        public CalculaJurosControllerTests()
        {
            _context = new ApiTestContext();
        }

        [Theory]
        [InlineData("GET", 100, 5)]
        [InlineData("GET", 50, 27)]
        [InlineData("GET", 1978, 3)]
        [InlineData("GET", 63728123123, 13)]
        public async Task GetJuros(string method, decimal valorInicial, int meses)
        {
            var request = new HttpRequestMessage(new HttpMethod(method), $"calculajuros?valorinicial={valorInicial}&meses={meses}");

            var response = await _context.Client.SendAsync(request);

            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}