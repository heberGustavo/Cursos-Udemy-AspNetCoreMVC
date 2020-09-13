using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidacaoRemotaa.Models
{
    public class PessoasContexto : DbContext
    {
        public DbSet<Pessoas> Pessoas { get; set; }

        public PessoasContexto(DbContextOptions<PessoasContexto> opcoes) : base(opcoes)
        {

        }
    }
}
