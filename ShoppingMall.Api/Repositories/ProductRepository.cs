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
            var product = await shoppingMallContext.Products.FindAsync(id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.shoppingMallContext.Products.ToListAsync();
            return products;
        }

        public async Task<IEnumerable<Product>> GetItemsByCategory(int id)
        {
            var products = await (from product in shoppingMallContext.Products
                                where product.CategoryId == id
                                select product).ToListAsync();
            return products;
        }
    }
}
