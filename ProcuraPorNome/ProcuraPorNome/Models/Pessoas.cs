﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProcuraPorNome.Models
{
    public class Pessoas
    {
        [Key]
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
