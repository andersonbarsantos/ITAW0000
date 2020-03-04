using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITAW000.Models
{
    public class RegraViewModel
    {
        [Display(Name = "Descricao")]
        public string  Descricao  { get; set; }

        [Required]
        [Display(Name = "Retorno")]
        public string SelectedRetorno { get; set; }
        public IEnumerable<Retorno> ListRetorno { get; set; }

        [Required]
        [Display(Name = "Situacao")]
        public string SelectedSituacao { get; set; }
        public IEnumerable<Situacao> ListSituacao { get; set; }

        [Required]
        [Display(Name = "Responsavel")]
        public string SelectedResponsavel { get; set; }
        public IEnumerable<Responsavel> ListResponsavel { get; set; }

        [Required]
        [Display(Name = "Sistema")]
        public string SelectedSistema { get; set; }
        public IEnumerable<Sistema> ListSistema { get; set; }

        [Required]
        [Display(Name = "Tipo")]
        public string SelectedTipo { get; set; }
        public IEnumerable<Tipo> ListTipo { get; set; }


    }
}