using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidacaoRemota.Models
{
    public class PessoasContext : DbContext 
    {
        public DbSet<Pessoas> Pessoas { get; set; }

        public PessoasContext(DbContextOptions<PessoasContext> opcoes ) : base(opcoes)
        {

        }

    }
}
