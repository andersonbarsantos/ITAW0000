using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITAW000.Models
{
    public class Retorno
    {       
        public int IdRetorno { get; set; }
        [Required(ErrorMessage = "Favor preencher o campo nome")]
        public string NomeRetorno { get; set; }
        [Required(ErrorMessage = "Favor preencher o campo descrição")]
        public string DescRetorno { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string Usuario { get; set; }

    }
}