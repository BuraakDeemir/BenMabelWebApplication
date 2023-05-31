using BenMabelProject.Services.FluentValidations;
using BenMabelProject.Services.Helpers.Images;
using BenMabelProject.Services.Services.Abstractions;
using BenMabelProject.Services.Services.Concrete;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Reflection;

namespace BenMabelProject.Services.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IImageHelper, ImageHelper>();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProfileService, ProfileService>();
            services.AddScoped<IBasketService, BasketService>();
            services.AddScoped<IFinanceService, FinanceService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddAutoMapper(assembly);
            services.AddControllersWithViews().AddFluentValidation(opt =>
            {
                opt.RegisterValidatorsFromAssemblyContaining<ProductValidator>();
                opt.RegisterValidatorsFromAssemblyContaining<PersonValidator>();
                //opt.RegisterValidatorsFromAssemblyContaining<ProducPricetValidator>();
                //opt.RegisterValidatorsFromAssemblyContaining<CategoryValidator>();
                //opt.RegisterValidatorsFromAssemblyContaining<ProductDetailValidator>();
                //opt.RegisterValidatorsFromAssemblyContaining<ProductImgValidator>();
                opt.DisableDataAnnotationsValidation = true;
                opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
            });
            return services;
        }
    }
}
