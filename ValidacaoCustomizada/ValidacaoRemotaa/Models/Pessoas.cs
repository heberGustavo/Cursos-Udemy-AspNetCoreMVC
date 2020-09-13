using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ValidacaoRemotaa.Validacao;

namespace ValidacaoRemotaa.Models
{
    public class Pessoas
    {
        [Key]
        public int PessoaId { get; set; }

        public string Nome { get; set; }
        [Adulto]
        public int Idade { get; set; }
    }
}
