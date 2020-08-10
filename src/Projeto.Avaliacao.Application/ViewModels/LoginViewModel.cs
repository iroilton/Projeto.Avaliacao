using AutoMapper;
using Validation = DomainValidation.Validation.ValidationResult;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Avaliacao.Application.ViewModels
{
    public class LoginViewModel
    {
        [Key]
        public int LoginID { get; set; }

        [Required(ErrorMessage = "Preencha o campo Login")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [Display(Name = "Login")]
        public string LoginUsuario { get; set; }
        [Required(ErrorMessage = "Preencha o campo Senha")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Preencha o campo Ativo")]
        public bool Ativo { get; set; }
        [Required(ErrorMessage = "Preencha o campo Bloqueado")]
        public bool Bloqueado { get; set; }
        public Validation ValidationResult { get; set; }
    }
}
