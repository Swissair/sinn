using System;
using System.Collections.Generic;

namespace SIENN.WebApi.Contracts
{
    public partial class ProductType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
