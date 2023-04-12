using Microsoft.AspNetCore.Components;
using ShoppingMall.Models.Dtos;

namespace ShoppingMall.Web.Pages
{
    public class DisplayProductsBase:ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
