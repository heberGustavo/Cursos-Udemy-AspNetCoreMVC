using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuitosParaMuitos.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Empregado> Empregados { get; set; }
        public DbSet<Trabalho> Trabalhos { get; set; }
        public DbSet<EmpregoTrabalho> EmpregoTrabalhos { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<EmpregoTrabalho>().HasKey(x => new { x.EmpregadoId, x.TrabalhoId});

            builder.Entity<EmpregoTrabalho>().HasOne(e => e.Empregado).WithMany(e => e.EmpregoTrabalhos).HasForeignKey(e => e.EmpregadoId);
            builder.Entity<EmpregoTrabalho>().HasOne(t => t.Trabalho).WithMany(t => t.EmpregoTrabalhos).HasForeignKey(t => t.TrabalhoId);
        }
    }
}
