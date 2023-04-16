using Microsoft.EntityFrameworkCore;
using ShoppingMall.Api.Data;
using ShoppingMall.Api.Entities;
using ShoppingMall.Api.Repositories.Contracts;
using ShoppingMall.Models.Dtos;

namespace ShoppingMall.Api.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly ShoppingMallContext shoppingMallContext;

        public ShoppingCartRepository(ShoppingMallContext shoppingMallContext)
        {
            this.shoppingMallContext = shoppingMallContext;
        }
        private async Task<bool> CartItemExists(int cartId, int productId)
        {
            return await this.shoppingMallContext.CartItems.AnyAsync(c => c.CartId == cartId &&
                                                                            c.ProductId == productId);
        }
        public async Task<CartItem> AddItem(CartItemToAddDto cartItemToAddDto)
        {
            if (await CartItemExists(cartItemToAddDto.CartId, cartItemToAddDto.ProductId) ==false) 
            {
                var item = await (from product in this.shoppingMallContext.Products
                                  where product.Id == cartItemToAddDto.ProductId
                                  select new CartItem
                                  {
                                      CartId = cartItemToAddDto.CartId,
                                      ProductId = product.Id,
                                      Qty = cartItemToAddDto.Qty,
                                  }).SingleOrDefaultAsync();

                if (item != null)
                {
                    var result = await this.shoppingMallContext.CartItems.AddAsync(item);
                    await this.shoppingMallContext.SaveChangesAsync();
                    return result.Entity;
                }
            }
            
            return null;
        }

        public async Task<CartItem> DeleteItem(int id)
        {
            var item = await this.shoppingMallContext.CartItems.FindAsync(id);
            if (item != null)
            {
                this.shoppingMallContext.CartItems.Remove(item);
                await this.shoppingMallContext.SaveChangesAsync();
            }
            return item;
        }

        public async Task<CartItem> GetItem(int id)
        {
            return await (from cart in this.shoppingMallContext.Carts
                          join cartItem in this.shoppingMallContext.CartItems
                          on cart.Id equals cartItem.Id
                          where cartItem.Id == id
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Qty = cartItem.Qty,
                              CartId = cartItem.CartId,
                          }).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<CartItem>> GetItems(int userId)
        {
            return await (from cart in this.shoppingMallContext.Carts
                          join cartItem in this.shoppingMallContext.CartItems
                          on cart.Id equals cartItem.CartId
                          where cart.UserId == userId
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Qty = cartItem.Qty,
                              CartId = cartItem.CartId,
                          }).ToListAsync();
        }

        public Task<CartItem> UpdateQty(int id, CartItemQtyUpdateDto cartItemQtyUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
