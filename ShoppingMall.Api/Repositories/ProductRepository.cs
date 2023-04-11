using Microsoft.EntityFrameworkCore;
using ShoppingMall.Api.Data;
using ShoppingMall.Api.Entities;
using ShoppingMall.Api.Repositories.Contracts;

namespace ShoppingMall.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShoppingMallContext shoppingMallContext;
        public ProductRepository(ShoppingMallContext shoppingMallContext)
        {
            this.shoppingMallContext = shoppingMallContext;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.shoppingMallContext.ProductCategorys.ToListAsync();
            return categories;
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.shoppingMallContext.Products.ToListAsync();
            return products;
        }
    }
}
