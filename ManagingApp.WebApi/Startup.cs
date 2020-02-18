using ManagingApp.WebApi.Data;
using ManagingApp.WebApi.Repositories.Implementations;
using ManagingApp.WebApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ManagingApp.WebApi
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
            // Configura o DbContext com a connection string no appsettings.json
            services.AddDbContext<ManagingAppWebApiContext>((options) =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("SqlServerDatabase"));
            });

            // Aqui estou registrando no "container" que a interface IProdutoProntoRepository é implementada por ProdutoProntoRepository.
            // Isso significa, que quando houver injeção de dependencia de IProdutoProntoRepository ele vai retornar uma instancia de ProdutoProntoRepository.
            // Existem 3 formas de registrar isso no container:
            // Scoped: Criará uma instancia de ProdutoProntoRepository por requisição
            // Transient: Criará uma instancia nova toda vez que for injetado
            // Singleton: Criará apenas uma instância e sempre usará a mesma
            // A mais comum é Scoped. A mais "perigosa" e rara é a Singleton
            services.AddScoped<IProdutoProntoRepository, ProdutoProntoRepository>();
            services.AddScoped<DbContext, ManagingAppWebApiContext>();

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
