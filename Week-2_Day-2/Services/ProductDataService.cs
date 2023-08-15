using Week_2_Day_2.Interfaces;
using Week_2_Day_2.Models;

namespace Week_2_Day_2.Services
{
    public class ProductDataService : IProductDataService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 799.99M },
                new Product { Id = 2, Name = "Smartphone", Price = 499.99M },
                new Product { Id = 3, Name = "Headphones", Price = 89.99M },
                new Product { Id = 4, Name = "Monitor", Price = 349.99M },
                new Product { Id = 5, Name = "Wireless Mouse", Price = 29.99M },
                new Product { Id = 6, Name = "Keyboard", Price = 69.99M },
                new Product { Id = 7, Name = "External Hard Drive", Price = 129.99M },
                new Product { Id = 8, Name = "Tablet", Price = 299.99M },
                new Product { Id = 9, Name = "Gaming Console", Price = 399.99M },
                new Product { Id = 10, Name = "Wireless Earbuds", Price = 149.99M }
            };
        }
    }
}
