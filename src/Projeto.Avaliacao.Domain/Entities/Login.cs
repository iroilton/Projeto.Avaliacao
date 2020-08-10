using DomainValidation.Validation;

namespace Projeto.Avaliacao.Domain.Entities
{
    public class Login
    {
        public int LoginID { get; set; }
        public string LoginUsuario { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public bool Bloqueado { get; set; }

        public Usuario Usuario { get; set; }

        public ValidationResult ValidationResult { get; set; }
    }
}
