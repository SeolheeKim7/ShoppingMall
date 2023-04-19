using ShoppingMall.Models.Dtos;

namespace ShoppingMall.Web.Services.Contracts
{
    public interface IManageProductsLocalStorageService
    {
        Task<IEnumerable<ProductDto>> GetCollection();
        Task RemoveCollection();
    }
}
