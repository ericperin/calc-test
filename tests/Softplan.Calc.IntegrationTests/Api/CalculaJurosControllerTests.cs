using System.Net.Http;
using Xunit;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using Softplan.Calc.Api;
using System.Net;
using System.Threading.Tasks;

namespace Softplan.Calc.IntegrationTests
{
    public class CalculaJurosControllerTests
    {
        private readonly HttpClient _client;
        public CalculaJurosControllerTests()
        {
            var server = new TestServer(new WebHostBuilder().UseEnvironment("Development").UseStartup<Startup>());
            _client = server.CreateClient();
        }

        [Theory]
        [InlineData("GET", 100, 5)]
        public async Task GetJuros(string method, decimal valorInicial, int meses)
        {
            var request = new HttpRequestMessage(new HttpMethod(method), $"calculajuros?valorinicial={valorInicial}&meses={meses}");

            var response = await _client.SendAsync(request);

            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}