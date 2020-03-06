using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITAW000.Models
{
    public class Sistema
    {
        public int IdSistema { get; set; }

        [Required(ErrorMessage = "Favor preencher o campo nome")]
        public string NomeSistema { get; set; }

        [Required(ErrorMessage = "Favor preencher o campo descrição")]
        public string DescSistema { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string Usuario { get; set; }
    }
}