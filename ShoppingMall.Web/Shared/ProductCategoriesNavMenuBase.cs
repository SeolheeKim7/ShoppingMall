﻿using Microsoft.AspNetCore.Components;
using ShoppingMall.Models.Dtos;
using ShoppingMall.Web.Services.Contracts;

namespace ShoppingMall.Web.Shared
{
    public class ProductCategoriesNavMenuBase:ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }
        public IEnumerable<ProductCategoryDto> ProductCategoryDtos { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                ProductCategoryDtos = await ProductService.GetProductCategories();
            }
            catch (Exception ex)
            {

                ErrorMessage = ex.Message;
            }
        }
    }
}

