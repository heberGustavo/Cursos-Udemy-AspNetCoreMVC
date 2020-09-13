using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroducaoFluenteAPI.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public int? Idade { get; set; }
        public double? Peso { get; set; }


        //Obs: Quando propriedade pode ser nula é necessario colocar '?'
    }
}
