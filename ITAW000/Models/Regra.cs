using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITAW000.Models
{
    public class Regra
    {
        public int IdRegra { get; set; }
        public bool Ativo { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Favor preencher o campo Descrição")]
        public string Descricao { get; set; }

        public int Quantidade { get; set; }
        public DateTime DtInicioVigencia { get; set; }
        public DateTime DtFimVigencia { get; set; }

        [Required]
        [Display(Name = "Sistema")]
        [Range(1, 1000, ErrorMessage = "Favor selecionar um sistema")]        
        public int IdSistema { get; set; }
        public Sistema Sistema { get; set; }

        [Required]
        [Display(Name = "Responsavel")]
        [Range(1, 1000, ErrorMessage = "Favor selecionar um responsavel")]
        public int IdResponsavel { get; set; }
        public Responsavel Responsavel { get; set; }

        [Required]
        [Display(Name = "Situacao")]
        [Range(1, 1000, ErrorMessage = "Favor selecionar um situacao")]
        public int IdSituacao { get; set; }
        public Situacao Situacao { get; set; }

        [Required]
        [Display(Name = "Tipo")]
        [Range(1, 1000, ErrorMessage = "Favor selecionar um tipo movimentação")]
        public int IdTipo { get; set; }
        public Tipo Tipo { get; set; }

        [Required]
        [Display(Name = "Retorno")]
        [Range(1, 1000, ErrorMessage = "Favor selecionar um retorno")]
        public int IdRetorno { get; set; }
        public Retorno Retorno { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string Usuario { get; set; }
    }
}
