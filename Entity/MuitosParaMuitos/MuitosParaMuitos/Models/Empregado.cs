using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuitosParaMuitos.Models
{
    public class Empregado
    {
        public int EmpregadoId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }

        //Esta empregado a 'N' EmpregadoTrabalho
        public ICollection<EmpregoTrabalho> EmpregoTrabalhos { get; set; }
    }
}
