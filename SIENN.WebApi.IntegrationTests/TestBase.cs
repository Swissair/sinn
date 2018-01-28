using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using NUnit.Framework;
using System.Net.Http;

namespace SIENN.WebApi.IntegrationTests
{
    public abstract class TestBase
    {
        protected TestServer _server;
        protected HttpClient _client;

        [SetUp]
        public void SetUp()
        {
            _server = new TestServer(new WebHostBuilder()
           .UseStartup<Startup>());
            _client = _server.CreateClient();
        }
    }
}