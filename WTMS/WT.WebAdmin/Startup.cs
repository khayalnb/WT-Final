using ActiviKidWebUI.Helper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using WT.BLL.Mapping;
using WT.DAL.Data;
using WT.WebAdmin.Helpers;

namespace WT.WebAdmin
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(opts =>
            {
                opts.UseSqlServer(Configuration.GetConnectionString("WtConnectionString"));
                //opts.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

            services.AddControllersWithViews(cfg =>
            {
                cfg.ModelBinderProviders.Insert(0, new BooleanBinderProvider());
            });
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddAutoMapper(typeof(CustomMapping));
            services.RegisterAppServices();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            }).UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("en-US"),
                // Aşağıdakı kod ilə UTF-8 kodlamasını təyin edin
                RequestCultureProviders = new List<IRequestCultureProvider>
                {
                   new QueryStringRequestCultureProvider(),
                   new CookieRequestCultureProvider(),
                   new AcceptLanguageHeaderRequestCultureProvider()
                },
                SupportedCultures = new List<CultureInfo>
                {
                   new CultureInfo("en-US"),
                },
                SupportedUICultures = new List<CultureInfo>
                {
                  new CultureInfo("az-Latn-AZ")
                }
            });
        }
    }
}
