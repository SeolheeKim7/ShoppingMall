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

        public async Task<ProductCategory> GetCategory(int id)
        {
            var category = await shoppingMallContext.ProductCategorys.SingleOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<Product> GetItem(int id)
        {
            var product = await shoppingMallContext.Products
                                .Include(p => p.ProductCategory)
                                .SingleOrDefaultAsync(p => p.Id == id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.shoppingMallContext.Products
                                .Include(p => p.ProductCategory)
                                .ToListAsync();
            return products;
        }

        public async Task<IEnumerable<Product>> GetItemsByCategory(int id)
        {
            var products = await this.shoppingMallContext.Products
                                .Include(p => p.ProductCategory)
                                .Where(p =>p.CategoryId == id)
                                .ToListAsync();
            return products;
        }
    }
}
