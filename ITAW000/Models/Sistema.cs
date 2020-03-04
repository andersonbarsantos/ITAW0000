﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITAW000.Models
{
    public class Sistema
    {
        public int IdSistema { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string Usuario { get; set; }
    }
}