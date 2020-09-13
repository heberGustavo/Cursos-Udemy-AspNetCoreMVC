using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeiro_CRUD.Models
{
    //Passo 2
    public class Contexto : DbContext
    {
        public DbSet<Carro> Carros { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    }
}
