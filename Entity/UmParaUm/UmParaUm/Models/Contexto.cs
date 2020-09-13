using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UmParaUm.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Pessoa>().HasOne(x => x.Endereco).WithOne(x => x.Pessoa).HasForeignKey<Pessoa>(x => x.EnderecoId);
            builder.Entity<Endereco>().HasOne(x => x.Pessoa).WithOne(x => x.Endereco);
        }
    }
}
