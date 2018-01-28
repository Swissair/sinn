using Newtonsoft.Json;
using NUnit.Framework;
using SIENN.DataConracts;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SIENN.WebApi.IntegrationTests
{
    [TestFixture]
    public class ProductControllerTests : TestBase
    {
        [Test]
        public async Task WhenAskedForAvailableProducts_ShouldReturnFirstPage()
        {
            var request = new GetAvailableProductsRequest
            {
                PageNumber = 4,
                PageSize = 20
            };

            var response = await _client.PostAsync("/api/Product/GetAvailableProducts",  new JsonContent(JsonConvert.SerializeObject(request)));

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var products = JsonConvert.DeserializeObject<GetAvailableProductsResponse>(responseString);

            Assert.AreEqual(1, products.Products.Count);
        }
    }
}
