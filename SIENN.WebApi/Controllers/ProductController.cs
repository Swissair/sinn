using Microsoft.AspNetCore.Mvc;
using SIENN.WebApi.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIENN.WebApi.Controllers
{

    [Route("api/[controller]/[action]")]
    public class ProductController : Controller
    {
        [HttpPost]
        public GetAvailableProductsResponse GetAvailableProducts(GetAvailableProductsRequest request)
        {
            return new GetAvailableProductsResponse
            {
                Products = new List<Product>
                {
                    new Product{ Id = 1, Description = "Philips tv"}
                }
            };
        }
    }
}
