using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITAW000.Models
{
    public class Responsavel
    {      
        public int IdResponsavel { get; set; }
        public string NomeResponsavel { get; set; }
        public string DescResponsavel { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string Usuario { get; set; }
    }
}