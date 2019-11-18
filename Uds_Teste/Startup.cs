using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.IO;
using Uds.WebApi;
using Uds.Infra.StoreContext.DataContexts;
using Uds.Domain.Repositories;
using Uds.Infra.StoreContext.Repositories;

namespace Uds_Teste
{
    public class Startup
    {
        public static IConfiguration Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            services.AddMvc();

            services.AddResponseCompression();
            services.AddCors();

            services.AddScoped<UdsDataContext, UdsDataContext>();
            services.AddTransient<IPizzaRepository, PizzaRepository>();

            services.AddTransient<ITamanhoRepository, TamanhoRepository>();
            services.AddTransient<ISaborRepository, SaborRepository>();
            services.AddTransient<IAdicionalPizzaRepository, AdicionalPizzaRepository>();
            services.AddTransient<IPersonalizacaoRepository, PersonalizacaoRepository>();
       
            Settings.ConnectionString = $"{Configuration["connectionString"]}";

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseCors(options =>
            {
                options.AllowAnyHeader();
                options.AllowAnyMethod();
                options.AllowAnyOrigin();
            });
            app.UseMvc();
        }
    }
}
