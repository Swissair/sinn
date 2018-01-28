using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIENN.DataContracts
{
    public class GetAvailableProductsRequest
    {
        public int PageNumber { get; set; }

        public int PageSize { get; set; }
    }

    public class GetAvailableProductsResponse
    {
        public List<Product> Products { get; set; }
    }
}
