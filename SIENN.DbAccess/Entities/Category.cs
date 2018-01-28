using System;
using System.Collections.Generic;

namespace SIENN.DbAccess.Models
{
    public partial class Category
    {
        public Category()
        {
            ProductCategories = new HashSet<ProductCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
