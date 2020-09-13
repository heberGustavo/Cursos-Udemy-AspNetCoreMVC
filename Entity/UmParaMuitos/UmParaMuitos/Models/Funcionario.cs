using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UmParaMuitos.Models
{
    public class Funcionario
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int TrabalhoId { get; set; }
        public Trabalho Trabalho { get; set; }
    }
}
