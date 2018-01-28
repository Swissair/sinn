using SIENN.DbAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIENN.Services.Contracts
{
    public interface IProductService
    {
        List<Product> GetAvailableProducts(int pageNumber, int pageSize);
    }
}
