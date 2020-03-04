using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITAW000.Models
{
    public class Retorno
    {       
        public int IdRetorno { get; set; }
        public string NomeRetorno { get; set; }
        public string DescRetorno { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string Usuario { get; set; }

    }
}