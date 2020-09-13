using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroducaoFluenteAPI.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Pessoa>().HasKey(x => x.PessoaId);
            builder.Entity<Pessoa>().Property(x => x.Nome).HasColumnName("Nome").HasColumnType("ntext").HasMaxLength(50).IsRequired();
            builder.Entity<Pessoa>().Property(x => x.Idade).HasColumnName("Idade").HasColumnType("int").IsRequired(false);
            builder.Entity<Pessoa>().Property(x => x.Peso).IsRequired(false);

            // Se não for alterar o nome ou tipo não é necessario informar
        }
    }
}


