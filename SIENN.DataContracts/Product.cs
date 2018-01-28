using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIENN.DataConracts
{
    public class Product
    {
        public Product()
        {
            Categories = new List<Category>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public bool? IsAvailable { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int ProductTypeId { get; set; }
        public int UnitId { get; set; }

        public ProductType ProductType { get; set; }
        public Unit Unit { get; set; }
        public List<Category> Categories { get; set; }
    }
}
