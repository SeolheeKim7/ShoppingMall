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

//                // Look for any Doctors.  Since we can't have patients without Doctors.
//                if (!context.Carts.Any())
//                {
//                    context.Carts.AddRange(
//                     new Cart
//                     {
//                         FirstName = "Gregory",
//                         MiddleName = "A",
//                         LastName = "House"
//                     },

//                     new Cart
//                     {
//                         FirstName = "Doogie",
//                         MiddleName = "R",
//                         LastName = "Houser"
//                     },
//                     new Doctor
//                     {
//                         FirstName = "Charles",
//                         LastName = "Xavier"
//                     });
//                    context.SaveChanges();
//                }
//                if (!context.Patients.Any())
//                {
//                    context.Patients.AddRange(
//                    new Patient
//                    {
//                        FirstName = "Fred",
//                        MiddleName = "Reginald",
//                        LastName = "Flintstone",
//                        OHIP = "1231231234",
//                        DOB = DateTime.Parse("1955-09-01"),
//                        ExpYrVisits = 6,
//                        DoctorID = context.Doctors.FirstOrDefault(d => d.FirstName == "Gregory" && d.LastName == "House").ID
//                    },
//                    new Patient
//                    {
//                        FirstName = "Wilma",
//                        MiddleName = "Jane",
//                        LastName = "Flintstone",
//                        OHIP = "1321321324",
//                        DOB = DateTime.Parse("1964-04-23"),
//                        ExpYrVisits = 2,
//                        DoctorID = context.Doctors.FirstOrDefault(d => d.FirstName == "Gregory" && d.LastName == "House").ID
//                    },
//                    new Patient
//                    {
//                        FirstName = "Barney",
//                        LastName = "Rubble",
//                        OHIP = "3213213214",
//                        DOB = DateTime.Parse("1964-02-22"),
//                        ExpYrVisits = 2,
//                        DoctorID = context.Doctors.FirstOrDefault(d => d.FirstName == "Doogie" && d.LastName == "Houser").ID
//                    },
//                    new Patient
//                    {
//                        FirstName = "Jane",
//                        MiddleName = "Samantha",
//                        LastName = "Doe",
//                        OHIP = "4124124123",
//                        ExpYrVisits = 2,
//                        DoctorID = context.Doctors.FirstOrDefault(d => d.FirstName == "Charles" && d.LastName == "Xavier").ID
//                    });
//                    context.SaveChanges();
//                }
//            }
//            catch (Exception ex)
//            {
//                Debug.WriteLine(ex.GetBaseException().Message);
//            }
//        }
//    }

//}
