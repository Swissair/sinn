using Microsoft.EntityFrameworkCore;
using SIENN.DbAccess.Contracts;
using SIENN.DbAccess.Framework;
using SIENN.DbAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIENN.DbAccess.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(SiennDbContext context) : base(context)
        {
        }

        public List<Product> GetAvailableProducts(int pageNumber, int pageSize)
        {
            var products = Find(x => x.IsAvailable == true);
            return products.ToList();
        }
    }
}
