using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SPENGO.API.IOC;
using SPENGO.Data;
using System;

namespace SPENGO.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddMvc();

            services.AddDbContext<ApplicationDataContext>(options => options.UseMySql(Configuration["ConnectionStrings:SPENGODB"], migration => migration.MigrationsAssembly("SPENGO.API")));

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("0.3.1", new OpenApiInfo
                {
                    Version = "0.3.1",
                    Title = "SPENGO API",
                    Description = "SPENGO is a software of control spents.",
                    Contact = new OpenApiContact
                    {
                        Name = "Pedro Octávio",
                        Email = "pedrooctavio.dev@outlook.com",
                        Url = new Uri("https://github.com/pedro-octavio")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "MIT",
                        Url = new Uri("https://github.com/pedro-octavio/SPENGO/blob/main/LICENSE")
                    }
                });
            });
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new ModuleIOC());
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger(s =>
            {
                s.SerializeAsV2 = true;
            });

            app.UseSwaggerUI(s => s.SwaggerEndpoint("/swagger/0.3.1/swagger.json", "SPENGO"));

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
