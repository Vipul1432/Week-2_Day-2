using Week_2_Day_2.Interfaces;
using Week_2_Day_2.Models;

namespace Week_2_Day_2.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IProductDataService _productContext;
        public ProductRepository(IProductDataService productContext)
        {
            _productContext = productContext;
        }
        public List<Product> GetAllProducts()
        {
            return  _productContext.GetProducts();
        }

        public Product GetProductById(int id)
        {
            return _productContext.GetProductById(id);
        }

        public void AddProduct(Product product)
        {
            _productContext.AddProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            _productContext.UpdateProduct(product);
        }

        public bool DeleteProduct(int id)
        {
           bool isDeleted = _productContext.DeleteProduct(id);
           return isDeleted;
        }
    }
}
