using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SIENN.DataContracts;
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
        private readonly IMapper _mapper;

        public ProductController(
            IProductService productService,
            IMapper mapper)
        {
            _productService = productService;
            this._mapper = mapper;
        }

        [HttpPost]
        public GetAvailableProductsResponse GetAvailableProducts(GetAvailableProductsRequest request)
        {
            var result = _productService.GetAvailableProducts(request.PageNumber, request.PageSize);
            var products = _mapper.Map<List<SIENN.DataContracts.Product>>(result);
            return new GetAvailableProductsResponse() { Products = products };
        }
    }
}
