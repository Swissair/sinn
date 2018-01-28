using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using NUnit.Framework;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SIENN.WebApi.IntegrationTests
{
    [TestFixture]
    public class SiennControllerTests : TestBase
    {
        [Test]
        public async Task WhenAskedForDefaultAction_ShouldGetSienn_PolandResponse()
        {
            var response = await _client.GetAsync("/api/Sienn");

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            Assert.AreEqual("SIENN Poland", responseString);
        }
    }
}
