﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ViewModels.Models
{
    public class Materia
    {
        [Key]
        public int MateriaId { get; set; }
        public string Nome { get; set; }
    }
}
