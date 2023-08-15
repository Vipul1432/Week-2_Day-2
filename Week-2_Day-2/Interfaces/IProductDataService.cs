using Week_2_Day_2.Models;

namespace Week_2_Day_2.Interfaces
{
    public interface IProductDataService
    {
        List<Product> GetProducts();
        Product GetProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        bool DeleteProduct(int id);
    }
}
