using Microsoft.EntityFrameworkCore;
using SIENN.DbAccess.Framework;
using SIENN.DbAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIENN.DbAccess.TestData
{
    public static class DataSeeds
    {
        public static void SeedData(this SiennDbContext context)
        {
            if (!context.Unit.Any())
            {
                var unitPiece = new Unit
                {
                    Name = "Piece",
                    Description = "Piece description",
                    Code = "PIECE"
                };

                var unitKilogram = new Unit
                {
                    Name = "Kilogram",
                    Description = "Measure of weight",
                    Code = "Kg"
                };

                var unitLiter = new Unit
                {
                    Name = "Litres",
                    Description = "Litres",
                    Code = "L"
                };

                context.Unit.AddRange(new List<Unit> { unitPiece, unitKilogram });
                context.SaveChanges();
            }

            if (!context.ProductType.Any())
            {
                var productTypes = new List<ProductType>();
                var tv = new ProductType
                {
                    Name = "TV Set",
                    Description = "TV sets",
                    Code = "TV"
                };
                productTypes.Add(tv);

                var clothing = new ProductType
                {
                    Name = "Clothes",
                    Description = "Garments, Clothing",
                    Code = "Clothes"
                };
                productTypes.Add(clothing);

                context.ProductType.AddRange(productTypes);
                context.SaveChanges();
            }

            if (!context.Category.Any())
            {
                var categories = new List<Category>();
                var electronics = new Category
                {
                    Name = "Electronics",
                    Description = "Electronics",
                    Code = "Electronics"
                };
                categories.Add(electronics);

                var houseHoldGoods = new Category
                {
                    Name = "Household",
                    Description = "Household goods",
                    Code = "Household"
                };
                categories.Add(houseHoldGoods);

                var garment = new Category
                {
                    Name = "Garment",
                    Description = "Garment goods",
                    Code = "garment"
                };
                categories.Add(garment);

                var shirts = new Category
                {
                    Name = "Shirts",
                    Description = "Shirts goods",
                    Code = "Shirts"
                };
                categories.Add(shirts);

                var cars = new Category
                {
                    Name = "Cars",
                    Description = "Cars",
                    Code = "Cars"
                };
                categories.Add(cars);

                var consoles = new Category
                {
                    Name = "Consoles",
                    Description = "Consoles",
                    Code = "Consoles"
                };
                categories.Add(consoles);

                var food = new Category
                {
                    Name = "Food",
                    Description = "Food",
                    Code = "Food"
                };
                categories.Add(food);

                var liquids = new Category
                {
                    Name = "Liquids",
                    Description = "Liquids",
                    Code = "Liquids"
                };
                categories.Add(food);

                context.Category.AddRange(categories);
                context.SaveChanges();
            }

            if (!context.Product.Any())
            {
                var electronicsCategory = context.Category.First(c => c.Name == "Electronics");
                var householdGoodsCategory = context.Category.First(c => c.Name == "Household");
                var garmentCategory = context.Category.First(c => c.Name == "Garment");
                var shirtsCategory = context.Category.First(c => c.Name == "Shirts");

                var carsCategory = context.Category.First(c => c.Name == "Cars");
                var consolesCategory = context.Category.First(c => c.Name == "Consoles");
                var foodCategory = context.Category.First(c => c.Name == "Food");
                var ligquidsCategory = context.Category.First(c => c.Name == "Liquids");


                var products = new List<Product>();

                var samsungTv = new Product
                {
                    Code = "SMTV46",
                    Description = "Modern tv",
                    DeliveryDate = DateTime.Now.AddDays(3),
                    IsAvailable = true,
                };

                samsungTv.ProductCategories = new List<ProductCategory>
                {
                    new ProductCategory { Category = electronicsCategory, Product = samsungTv},
                    new ProductCategory { Category = householdGoodsCategory, Product = samsungTv}
                };

                products.Add(samsungTv);


                context.Product.AddRange(products);
                context.SaveChanges();
            }
        }

        // Could use builder pattern with fluent API
        private static Product GetProduct(string name, decimal price, bool isAvailable = true, DateTime? nextDeliveryDate = null)
        {
            var product = new Product()
            {
                Name = name,
                Description = name + " description",
                Code = name.ToUpper(),
                IsAvailable = isAvailable,
                DeliveryDate = nextDeliveryDate,
                Price = price
            };

            return product;
        }
    }
}
