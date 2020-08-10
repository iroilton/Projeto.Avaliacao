using Projeto.Avaliacao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Validation = DomainValidation.Validation.ValidationResult;

namespace Projeto.Avaliacao.Application.ViewModels
{
    public class UsuarioViewModel : IDisposable
    {
        public UsuarioViewModel()
        {
            Login = new LoginViewModel();
            Telefones = new List<TelefoneViewModel>();
        }

        [Key]
        public int UsuarioID { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo CPF")]
        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        public string CPF { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome da Mãe")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Nome da Mãe")]
        public string NomeMae { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataInclusao { get; set; }
        [ScaffoldColumn(false)]
        public DateTime? DataAlteracao { get; set; }
        [Required(ErrorMessage = "Preencha o campo Ativo")]
        public bool Ativo { get; set; }


        public ICollection<TelefoneViewModel> Telefones { get; set; }
        public LoginViewModel Login { get; set; }

        public Validation ValidationResult { get; set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
