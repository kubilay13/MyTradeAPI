using MyTradeAPI.Data;
using MyTradeAPI.Models.ProductModel;

namespace MyTradeAPI.Services.UserService
{
    public class ProductService
    {
        private readonly AppDbContext _appDbContext;

        public ProductService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // İlanları Listeleme
        public List<Product> getAllProducts()
        {
            var product= _appDbContext.Products.ToList();
            return product;
        }
    }
}
