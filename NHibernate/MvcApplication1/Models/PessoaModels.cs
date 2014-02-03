using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcApplication1.Models
{
    public class PessoaModel
    {
        [Key]
        public int IdPessoa { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Nome da Mãe é obrigatório")]
        [Display(Name = "Nome da Mãe")]
        public string NomeMae { get; set; }

        [Required(ErrorMessage = "Nome do Pai é obrigatório")]
        [Display(Name = "Nome do Pai")]
        public string NomePai { get; set; }

        [Required(ErrorMessage = "Data de Nascimento é obrigatório")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime? DataNascimento { get; set; }

        [Required(ErrorMessage = "RG é obrigatório")]
        [Display(Name = "RG")]
        public string RG { get; set; }

        [Required(ErrorMessage = "CPF é obrigatório")]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Required]
        [Display(Name = "Estrangeiro")]
        public bool Estrangeiro { get; set; }

        [Display(Name = "Identidade estrangeira")]
        public string IdentidadeEstrangeira { get; set; }

    }
}
