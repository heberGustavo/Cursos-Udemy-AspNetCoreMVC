using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuitosParaMuitos.Models
{
    //Liga as duas tabelas, pois não é possivel fazer ligação 'N' para 'N' direto, é necessario de uma table auxiliar
    public class EmpregoTrabalho
    {
        public int EmpregadoId { get; set; }
        public Empregado Empregado { get; set; }

        public int TrabalhoId { get; set; }
        public Trabalho Trabalho { get; set; }

        public int CargaHoraria { get; set; }
    }
}
