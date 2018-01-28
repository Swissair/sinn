using SIENN.DbAccess.Contracts;
using SIENN.DbAccess.Models;
using SIENN.DbAccess.Repositories;
using SIENN.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Product> GetAvailableProducts(int pageNumber, int pageSize)
        {
            var products = _productRepository.GetAvailableProducts(pageNumber, pageSize);
            return products;
        }
    }
}
