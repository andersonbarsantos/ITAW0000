using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITAW000.Models
{
    public class Responsavel
    {      
        public int IdResponsavel { get; set; }

        [Required(ErrorMessage = "Favor preencher o campo nome")]
        public string NomeResponsavel { get; set; }
        [Required(ErrorMessage = "Favor preencher o campo descrição")]
        public string DescResponsavel { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string Usuario { get; set; }
    }
}