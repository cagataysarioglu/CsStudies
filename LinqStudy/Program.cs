using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Bilgisayar"},
                new Category{CategoryId = 2, CategoryName = "Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ ProductId = 1, CategoryId = 1, ProductName = "MSI GP62", Quantity = "16 GB RAM", UnitPrice = 7890, UnitsInStock = 30},
                new Product{ ProductId = 2, CategoryId = 1, ProductName = "MSI GTX40", Quantity = "32 GB RAM", UnitPrice = 9300, UnitsInStock = 24},
                new Product{ ProductId = 3, CategoryId = 1, ProductName = "MSI GS32", Quantity = "8 GB RAM", UnitPrice = 6370, UnitsInStock = 26},
                new Product{ ProductId = 4, CategoryId = 2, ProductName = "VENUS Z40", Quantity = "2.1 GHz", UnitPrice = 3450, UnitsInStock = 0},
                new Product{ ProductId = 5, CategoryId = 2, ProductName = "VENUS V7", Quantity = "2.0 GHz", UnitPrice = 2500, UnitsInStock = 11}
            };

            //ClassicLinq(products);

            //JoinLinq(products, categories);

            //Algorithmical
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock < 25)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            GetProducts(products);

            //LINQ
            var result = products.Where(product => product.UnitPrice > 5000 && product.UnitsInStock < 25);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
            GetProductsLinq(products);
        }

        private static void JoinLinq(List<Product> products, List<Category> categories)
        {
            var join_linq_result = from p in products
                                   join c in categories on p.CategoryId equals c.CategoryId
                                   select new ProductDto
                                   {
                                       ProductId = p.ProductId,
                                       ProductName = p.ProductName,
                                       UnitPrice = p.UnitPrice,
                                       CategoryName = c.CategoryName
                                   };
            foreach (var productDto in join_linq_result)
            {
                Console.WriteLine("{0}: {1}", productDto.ProductName, productDto.CategoryName);
            }
        }

        private static void ClassicLinq(List<Product> products)
        {
            var classic_linq_result = from p in products
                                      where p.UnitPrice > 6000
                                      orderby p.UnitPrice descending, p.ProductName ascending
                                      select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            foreach (var product in classic_linq_result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        //Algorithmical
        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock < 25)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }

        //LINQ
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(product => product.UnitPrice > 5000 && product.UnitsInStock < 25).ToList();
        }
    }

    class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public decimal UnitPrice { get; set; }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
