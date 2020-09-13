using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMoedas01.Models
{
    public class Moedas
    {
        [Key]
        public int MoedaID { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        [NotMapped]
        public bool CheckboxPreenchido { get; set; }

    }
}
