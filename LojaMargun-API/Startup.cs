using LojaMargun_Domain.Core.Interfaces.Repositories;
using LojaMargun_Infrastructure.Data;
using LojaMargun_Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.IO;

namespace LojaMargun_API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Context>(value => value.UseSqlServer(configuration.GetConnectionString("SqlServerConnection")));
            services.AddCors();
            services.AddControllers();
            services.AddSpaStaticFiles(path => path.RootPath = "LojaMargun-UI");
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "LojaMargun_API", Version = "v1" });
            });

            services.AddScoped<IBagRepository, BagRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<ISaleRepository, SaleRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LojaMargun_API v1"));
            }

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = Path.Combine(Directory.GetCurrentDirectory(), "LojaMargun-UI");

                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                    spa.UseProxyToSpaDevelopmentServer("http://localhost:4200/");
                }
            });

            app.UseHttpsRedirection();
            app.UseCors(value => value.AllowAnyOrigin().AllowAnyOrigin().AllowAnyHeader());
            app.UseSpaStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
