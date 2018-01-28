using System;
using System.Collections.Generic;

namespace SIENN.DbAccess.Models
{
    public partial class Unit
    {
        public Unit()
        {
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
