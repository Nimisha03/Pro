using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outlet.Demo.DataServices.Data.context;
using Microsoft.EntityFrameworkCore;

using Npgsql.EntityFrameworkCore.PostgreSQL;

using Microsoft.Extensions.Options;

using Outlet.Demo.BusinessServices.contracts;
using Outlet.Demo.BusinessServices.services;
using ApplicationDbContext = Outlet.Demo.DataServices.Data.context.ApplicationDbContext;
using Outlet.Demo.DataServices.contracts;
using Outlet.Demo.DataServices.services;
using Outlet.Demo.DataServices.Profiles;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore.Design;
using EFCore.NamingConventions;

namespace Outlet.Demo
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


            services.AddControllers();
            services.AddSwaggerGen(c =>

            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Outlet.Demo", Version = "v1" });
            });
            services.AddScoped<IOutletService, OutletService>();
            services.AddScoped<IOutletDataService, OutletDataService>();
            services.AddScoped<IVolunteerService, VolunteerService>();
            services.AddScoped<IVolunteerDataService, VolunteerDataService>();


            services.AddDbContext<ApplicationDbContext>(options => options
            .UseNpgsql("server=localhost; Port=5433; Database=outlet_demo1; User Id=postgres; Password=nimisha@03;")
            .UseSnakeCaseNamingConvention());
            var config = new AutoMapper.MapperConfiguration(c =>
            {
                c.AddProfile(new ApplicationProfile());
            });

            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);

        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Demo v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
           




    }
    }
}
