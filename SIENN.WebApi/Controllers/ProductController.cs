using Microsoft.AspNetCore.Mvc;
using SIENN.DataConracts;
using SIENN.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIENN.WebApi.Controllers
{

    [Route("api/[controller]/[action]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public GetAvailableProductsResponse GetAvailableProducts(GetAvailableProductsRequest request)
        {
            var result = _productService.GetAvailableProducts(request);
            return result;
        }
    }
}
