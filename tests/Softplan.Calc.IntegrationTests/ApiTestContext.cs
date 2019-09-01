using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Softplan.Calc.Api;

namespace Softplan.Calc.IntegrationTests
{
    public class ApiTestContext
    {
        public HttpClient Client { get; set; }
        private TestServer _server;
        public ApiTestContext()
        {
            SetupClient();
        }
        private void SetupClient()
        {
            _server = new TestServer(new WebHostBuilder().UseEnvironment("Development").UseStartup<Startup>());
            Client = _server.CreateClient();
        }
    }
}