﻿namespace ShoppingMall.Api.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public ICollection<Cart> Carts { get; set; }
    }
}
