﻿using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class Carros
    {
        public int CarroId { get; set; }
        public string Marca { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }
    }
}
