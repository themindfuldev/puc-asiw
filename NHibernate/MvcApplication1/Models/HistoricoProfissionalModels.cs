using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcApplication1.Models
{
    public class HistoricoProfissionalModel
    {
        [Key]
        public int IdHistoricoProfissional { get; set; }

        public int IdPessoa { get; set; }

        [Required(ErrorMessage = "Empresa é obrigatório")]
        [Display(Name = "Empresa")]
        public string Empresa { get; set; }

        [Required(ErrorMessage = "Cargo é obrigatório")]
        [Display(Name = "Cargo")]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "Data de Início é obrigatório")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Início")]
        public DateTime? DataInicio { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data Final")]
        public DateTime? DataFim { get; set; }

        [Required(ErrorMessage = "Habilidades Pessoais é obrigatório")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Habilidades Pessoais")]
        public string HabilidadePessoal { get; set; }

        [Required(ErrorMessage = "Habilidades Técnicas é obrigatório")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Habilidades Técnicas")]
        public string HabilidadeTecnica { get; set; }

    }
}
