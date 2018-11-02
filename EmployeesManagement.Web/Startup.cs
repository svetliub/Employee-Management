﻿namespace EmployeesManagement.Web
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeesManagement.Data;
    using EmployeesManagement.Services;
    using EmployeesManagement.Services.Interfaces;
    using EmployeesManagement.Web.Common;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.HttpsPolicy;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Routing;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using AutoMapper;

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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<EmployeesManagementContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("EmployeesManagementConnection"),
                    dbOptions => dbOptions.MigrationsAssembly("EmployeesManagement.Data")));

            services.Configure<RouteOptions>(options => options.LowercaseUrls = true);

            services.AddAutoMapper();

            RegisterServiceLayer(services);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.SeedDatabase();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private void RegisterServiceLayer(IServiceCollection services)
        {
            services.AddScoped<ICompaniesService, CompaniesService>();
            services.AddScoped<IEmployeesSecrvice, EmployeesSecrvice>();
            services.AddScoped<ITownsService, TownsService>();
            services.AddScoped<IExperienceLevelsSecrvice, ExperienceLevelsSecrvice>();
        }
    }
}
