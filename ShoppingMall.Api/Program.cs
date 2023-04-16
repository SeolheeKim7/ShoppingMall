
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Net.Http.Headers;
using ShoppingMall.Api.Data;
using ShoppingMall.Api.Repositories;
using ShoppingMall.Api.Repositories.Contracts;
using System.Text.Json.Serialization;


namespace ShoppingMall.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<ShoppingMallContext>(options =>
            options.UseSqlite(builder.Configuration.GetConnectionString("ShoppingMallContext")));

            //To give access to IHttpContextAccessor for Audit Data with IAuditable
            builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors(policy =>
            policy.WithOrigins("https://localhost:7016", "https://localhost:7016")
                .AllowAnyMethod()
                .WithHeaders(HeaderNames.ContentType)
            );
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}