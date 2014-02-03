using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcApplication1.Models
{
    public class HistoricoAcademicoModel
    {
        [Key]
        public int IdHistoricoAcademico { get; set; }

        public int IdPessoa { get; set; }

        [Required(ErrorMessage = "Curso é obrigatório")]
        [Display(Name = "Curso")]
        public string Curso { get; set; }

        [Required(ErrorMessage = "Instituição é obrigatório")]
        [Display(Name = "Instituição")]
        public string Instituicao { get; set; }

        [Required(ErrorMessage = "Data de Início é obrigatório")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Início")]
        public DateTime? DataInicio { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Término")]
        public DateTime? DataFim { get; set; }

        [Required(ErrorMessage = "Nota é obrigatório")]
        [Display(Name = "Nota")]
        public float? Nota { get; set; }

        [Required(ErrorMessage = "Percentual de presença é obrigatório")]
        [Display(Name = "Percentual de presença")]
        public float? Presenca { get; set; }

    }
}
