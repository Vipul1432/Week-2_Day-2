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
            return _productContext.GetProducts().FirstOrDefault(p => p.Id == id)!;
        }

        public void AddProduct(Product product)
        {
            product.Id = _productContext.GetProducts().Max(p => p.Id) + 1; 
            _productContext.GetProducts().Add(product);
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = _productContext.GetProducts().FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
            }
        }

        public void DeleteProduct(int id)
        {
            var product = _productContext.GetProducts().FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _productContext.GetProducts().Remove(product);
            }
        }
    }
}
