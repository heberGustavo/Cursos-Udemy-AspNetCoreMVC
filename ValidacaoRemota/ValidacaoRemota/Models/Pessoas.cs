using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValidacaoRemota.Models
{
    public class Pessoas
    {
        [Key]
        public int PessoaId { get; set; }

        [Remote("UsuarioExiste", "Pessoas")]
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
