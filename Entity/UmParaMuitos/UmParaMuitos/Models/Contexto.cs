using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UmParaMuitos.Models;

namespace UmParaMuitos.Models
{
    public class Contexto : DbContext
    {
        public Funcionario Funcionarios { get; set; }
        public Trabalho Trabalhos { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Funcionario>().HasOne(f => f.Trabalho).WithMany(f => f.Funcionarios).HasForeignKey(f => f.TrabalhoId);
            builder.Entity<Trabalho>().HasMany(t => t.Funcionarios).WithOne(t => t.Trabalho);
        }

        public DbSet<UmParaMuitos.Models.Trabalho> Trabalho { get; set; }

        public DbSet<UmParaMuitos.Models.Funcionario> Funcionario { get; set; }

    }
}
