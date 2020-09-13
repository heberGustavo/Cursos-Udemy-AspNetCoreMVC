using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploAjax.Models
{
    public class AjaxContexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public AjaxContexto(DbContextOptions<AjaxContexto> opcoes) : base(opcoes)
        {

        }
    }
}
