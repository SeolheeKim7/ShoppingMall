using ShoppingMall.Models.Dtos;

namespace ShoppingMall.Web.Services.Contracts
{
    public interface IManageCartItemsLocalStorageService
    {
        Task<List<CartItemDto>> GetCollection();
        Task SaveCollection(List<CartItemDto> cartItemDtos);

        Task RemoveCollection();
    }
}
