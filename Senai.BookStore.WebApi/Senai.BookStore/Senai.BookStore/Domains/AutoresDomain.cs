﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.BookStore.Domains
{
    public class AutoresDomain
    {
        public int IdAutor { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Ativo { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
