using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Primeiro_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace Primeiro_CRUD
{
    /*
     * PASSOS PARA CRIAR CONEXÃO COM BANCO DE DADOS
     * 
     * 1 - Criar Classe (Models/Carros)
     * 2 - Criar Classe Contexto (Models/Contexto)
     * 3 - Configuração no 'appsettings.json'
     * 4 - Adicionar na Classe Startup a configuração e instalar o pct de UseSqlServer = 'Microsoft.EntityFrameworkCore.SqlServer'
    */
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //Passo 4
            services.AddDbContext<Contexto>(opcao => opcao
            .UseSqlServer(Configuration.GetConnectionString("ConexaoDB")));

            //Ferramentas -> Gerenciador de Pct NuGet -> Console 
            //***Com o console aberto ...
            //Pacote - 'Microsoft.EntityFrameworkCore.Tools'
            //Add-Migration NomeDoMigretion (PrimeiroMigration)
            //update-database - Criar banco

            services.AddControllersWithViews();
        }

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
                    pattern: "{controller=Carros}/{action=Index}/{id?}");
            });
        }
    }
}
