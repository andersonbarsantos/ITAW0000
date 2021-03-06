﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITAW000.Models
{
    public class Situacao
    {
        public int IdSituacao { get; set; }
        [Required(ErrorMessage = "Favor preencher o campo nome")]
        public string NomeSituacao { get; set; }
        [Required(ErrorMessage = "Favor preencher o campo descrição")]
        public string DescSituacao { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string Usuario { get; set; }
    }
}