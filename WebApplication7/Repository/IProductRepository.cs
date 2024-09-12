using WebApplication7.Models;

namespace WebApplication7.Repository
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        void CreateProduct(Product obj);
        Product GetProductById(int id);

     

        

        void EditProduct(Product obj);
        string DeleteProductById(int id);
        List<Product> GetOutOfStockProducts();
        List<Product> GetProductsBetweenPriceRange(int lowerPriceLimit, int upperPriceLimit);

        List<string> GetProductsCategoryNames();
        List<Product> GetProductsByCategory(string category);
    }
}
