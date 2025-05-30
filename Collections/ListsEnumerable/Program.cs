using static ListEnumerable.Program;
using System.Collections.Generic;

namespace ListEnumerable
{
    internal class Program
    {
        public static void Main(string[] args)
        {
  
            //List<Products> productss = GetProductss();
            IEnumerable<Products> products = GetProducts();

            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }
        }

        public static IEnumerable<Products> GetProducts()
        {
            return  new List<Products>
            {
                new Products { Name = "iPhone", Price = 10 },
                new Products { Name = "Samsung", Price = 20 },
                new Products { Name = "OnePlus", Price = 30 }
            };

        }
        //We can declare like this but Ienumerable is better for iteration 
        public static List<Products> GetProductss()
        {
            return new List<Products>
            {
                new Products { Name = "iPhone", Price = 10 },
                new Products { Name = "Samsung", Price = 20 },
                new Products { Name = "OnePlus", Price = 30 }
            };
        }

        public class Products
        {
            public string? Name { get; set; }
            public int Price { get; set; }
        }



    }
}