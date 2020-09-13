using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidacaoDeDados.Models
{
    public class TarefaContexto : DbContext
    {
        public DbSet<Tarefas> Tarefas { get; set; }

        public TarefaContexto(DbContextOptions<TarefaContexto> opcoes) : base(opcoes)
        {

        }
    }
}
