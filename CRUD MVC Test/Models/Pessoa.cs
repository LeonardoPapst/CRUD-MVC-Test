using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_MVC_Test.Models
{
    public class Pessoa
    {
        [Key]
        public int PessoaId { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Telefone residencial é obrigatório")]
        [Display(Name = "Telefone Res.")]
        [Phone]
        public string TelefoneRes { get; set; }
        
        [Phone]
        public string Celular { get; set; }
    }
}