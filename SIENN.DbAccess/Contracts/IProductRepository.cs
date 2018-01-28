using SIENN.DbAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIENN.DbAccess.Contracts
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        List<Product> GetAvailableProducts(int pageNumber, int pageSize);
    }
}
