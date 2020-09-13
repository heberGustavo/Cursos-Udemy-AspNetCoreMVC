using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppListaTarefas.Models
{
    //Passo 2
    public class TarefasContexto : DbContext 
    {
        public DbSet<Tarefas> Tarefas { get; set; }
        public TarefasContexto(DbContextOptions<TarefasContexto> opcoes) : base(opcoes)
        {

        }
    }
}
