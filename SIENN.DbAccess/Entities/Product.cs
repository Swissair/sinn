using System;
using System.Collections.Generic;

namespace SIENN.DbAccess.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductCategories = new HashSet<ProductCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public bool? IsAvailable { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int ProductTypeId { get; set; }
        public int UnitId { get; set; }

        public ProductType ProductType { get; set; }
        public Unit Unit { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
