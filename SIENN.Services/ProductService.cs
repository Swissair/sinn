using SIENN.DataConracts;
using SIENN.DbAccess.Contracts;
using SIENN.DbAccess.Repositories;
using SIENN.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIENN.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public GetAvailableProductsResponse GetAvailableProducts(GetAvailableProductsRequest request)
        {
            var products = _productRepository.GetAvailableProducts(request.PageNumber, request.PageSize);

            return new GetAvailableProductsResponse { Products = new List<Product> { new Product { Description = "Tada" } } };
        }
    }
}
