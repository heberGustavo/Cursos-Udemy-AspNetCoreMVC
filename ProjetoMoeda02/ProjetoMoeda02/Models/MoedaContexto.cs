using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMoeda02.Models
{
    public class MoedaContexto : DbContext
    {
        public DbSet<Moedas> Moedas { get; set; }

        public MoedaContexto(DbContextOptions<MoedaContexto> opcoes) : base(opcoes)
        {

        }
    }
}
