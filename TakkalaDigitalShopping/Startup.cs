using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TakkalaDigitalShopping.Data;
using TakkalaDigitalShopping.Data.interfaces;
using TakkalaDigitalShopping.Data.mocks;

namespace TakkalaDigitalShopping
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        private IConfigurationRoot _configurationroot;
        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment)
        {
            _configurationroot = new ConfigurationBuilder().SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings1.json")
                .Build();
                
        }
        
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(_configurationroot.GetConnectionString("DefaultConnection")));

            services.AddTransient<IProductRepository, MockProductRepository>();
            services.AddTransient<IGroupRepository, MockGroupRepository>();
            services.AddTransient<ISubGroupRepository, MockSubGroupRepository>();
            services.AddTransient<IBrandRepository, MockBrandRepository>();
            services.AddMvc();
            services.AddRazorPages().AddRazorRuntimeCompilation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {

                endpoints.MapDefaultControllerRoute();

            });

            
        }
    }
}
