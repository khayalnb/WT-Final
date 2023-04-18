using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WT.BLL.Services;
using WT.BLL.Services.Interfaces;
using WT.DAL.Repository;
using WT.DAL.Repository.Interfaces;

namespace WT.WebAdmin.Helpers
{
    public static class AddService
    {
        public static IServiceCollection RegisterAppServices(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddScoped(typeof(IAdressTypeService),typeof(AdressTypeService));
            services.AddScoped(typeof(IShopAndOfficeService),typeof(ShopAndOfficeService));
            services.AddScoped(typeof(IOfferCompanyService), typeof(OfferCompanyService));
            services.AddScoped(typeof(IProductService), typeof(ProductService));
            services.AddScoped(typeof(IBrandService), typeof(BrandService));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));
            services.AddScoped(typeof(IGlobalService<>), typeof(GlobalService<>));
            services.AddScoped(typeof(ICategoryService),typeof(CategoryService));
            services.AddScoped(typeof(ISubCategoryService), typeof(SubCategoryService));
            return services;
        }
    } 
}
