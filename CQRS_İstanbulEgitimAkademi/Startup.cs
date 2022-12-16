using CQRS_İstanbulEgitimAkademi.CQRS.Handlers.ProductHandlers;
using CQRS_İstanbulEgitimAkademi.CQRS.Handlers.StudentHandlers;
using CQRS_İstanbulEgitimAkademi.DAL.Context;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_İstanbulEgitimAkademi
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
            services.AddDbContext<ProductContext>();

            services.AddScoped<GetProductQueryHandler>();
            services.AddScoped<GetProductQueryHandler2>();
            services.AddScoped<StudentQueryHandler>();
            services.AddScoped<CreateStudentCommandHandler>();
            services.AddScoped<GetStudentByIDQueryHandler>();
            services.AddScoped<RemoveStudentCommandHandler>();
            services.AddScoped<UpdateStudentCommandHandler>();

            services.AddMediatR(typeof(Startup));

            //base class
            //abstract class
            //type of startup
            //unit
            //override
            //overload

            services.AddControllersWithViews();
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
            });
        }
    }
}
