//using ShoppingMall.Api.Entities;
//using Microsoft.EntityFrameworkCore;
//using System.Diagnostics;

//namespace ShoppingMall.Api.Data
//{
//    public static class SMInitializer
//    {
//        public static void Seed(IApplicationBuilder applicationBuilder)
//        {
//            ShoppingMallContext context = applicationBuilder.ApplicationServices.CreateScope()
//                .ServiceProvider.GetRequiredService<ShoppingMallContext>();
//            try
//            {
//                //Delete the database if you need to apply a new Migration
//                context.Database.EnsureDeleted();
//                //Create the database if it does not exist and apply the Migration
//                context.Database.Migrate();

//                
//                if (!context.Carts.Any())
//                {
//                    
//                }
//                if (!context.Patients.Any())
//                {
//                    
//                }
//            }
//            catch (Exception ex)
//            {
//                Debug.WriteLine(ex.GetBaseException().Message);
//            }
//        }
//    }

//}
