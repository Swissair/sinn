using SIENN.DataConracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIENN.Services.Contracts
{
    public interface IProductService
    {
        GetAvailableProductsResponse GetAvailableProducts(GetAvailableProductsRequest request);
    }
}
