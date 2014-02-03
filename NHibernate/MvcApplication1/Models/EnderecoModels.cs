using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using Core.Domain.Model;

namespace MvcApplication1.Models
{
    public class EnderecoModel
    {
        [Key]
        public int IdEndereco { get; set; }

        public int IdPessoa { get; set; }

        [Required(ErrorMessage = "CEP é obrigatório")]
        [Display(Name = "CEP")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Número é obrigatório")]
        [Display(Name = "Número")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Bairro é obrigatório")]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Display(Name = "Complemento")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Estado é obrigatório")]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Logradouro é obrigatório")]
        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Cidade é obrigatório")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "País é obrigatório")]
        [Display(Name = "País")]
        public string Pais { get; set; }
    }
}
