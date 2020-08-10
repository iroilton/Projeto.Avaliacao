using System.ComponentModel.DataAnnotations;

namespace Projeto.Avaliacao.Application.ViewModels
{
    public class TelefoneViewModel
    {
        [Key]
        public int TelefoneID { get; set; }
        [ScaffoldColumn(false)]
        public int UsuarioID { get; set; }

        [Required(ErrorMessage = "Preencha o campo Fone")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        public string Fone { get; set; }

        [Required(ErrorMessage = "Preencha o campo Ativo")]
        public bool Ativo { get; set; }
    }
}
