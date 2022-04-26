using AutoMapper;
using DataAccess.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.ClienteServices;
using Services.ListaProductosOrdenServices;
using Services.OrdenServices;
using Services.ProductoServices;
using System;

namespace ApiProject
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
            //AutoMapper
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //DbContext
            services.AddDbContext<SistemaVentasContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SistemaPruebaConnection"))
            );

            services.AddScoped<SistemaVentasContext>();
            services.AddScoped<IClienteServices, ClienteServices>();
            services.AddScoped<IListaProductoOrdenServices, ListaProductoOrdenServices>();
            services.AddScoped<IOrdenServices, OrdenServices>();
            services.AddScoped<IProductoServices, ProductoServices>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
