using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppListaTarefas.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AppListaTarefas
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
            //Passo 4
            services.AddDbContext<TarefasContexto>(opcoes => opcoes.UseSqlServer(Configuration.GetConnectionString("ConexaoBancoDeDados")));
            services.AddControllersWithViews();

            //Passo 5 - Cria BD
            /*
             * Add-Migration PrimeiroMigration
             * Update-Database
             */
             //Passo 6 - Cria os Controller e Views
             //Passo 7 - No metodo Configure da classe Startup, trocar 'Home' pelo nome da rota
             //Passo 8 - Classe _Layout ->Remover Links da NavBar e adicionar 'Tarefas' em um link logo acima da NavBar 
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
                    pattern: "{controller=Tarefas}/{action=Index}/{id?}");
            });
        }
    }
}
