using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PesquisaCriptoMoeda.Models
{
    public class Moedas
    {
        [Key]
        public int MoedasId { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        //Não será mapeada para o banco de dados
        [NotMapped]
        public bool CheckboxMarcado { get; set; }

    }
}
