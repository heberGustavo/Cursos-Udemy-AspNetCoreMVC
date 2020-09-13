using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DbFirst.Models
{
    /*
     * Para criar esse classe e conexão com o BD
     * 
     * Install-Package Microsoft.EntityFrameworkCore.Tools
     * Install-Package Microsoft.EntityFrameworkCore.SqlServer
     * Scaffold-DbContext "Server=(localdb)\mssqllocaldb;Database=CarroDB;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
     */
     /*
      * Passo a passo
      * 1. Após criar essa classe ...
      * 2. Configurações em appsetings (ConnectionsStrings)
      * 3. Startup - Inserir serviços
      */
    public partial class CarroDBContext : DbContext
    {
        public CarroDBContext()
        {
        }

        public CarroDBContext(DbContextOptions<CarroDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Carros> Carros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carros>(entity =>
            {
                entity.HasKey(e => e.CarroId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
