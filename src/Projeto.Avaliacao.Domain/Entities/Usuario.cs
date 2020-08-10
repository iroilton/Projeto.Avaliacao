using DomainValidation.Validation;
using System;
using System.Collections.Generic;

namespace Projeto.Avaliacao.Domain.Entities
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string NomeMae { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public bool Ativo { get; set; }

        public Login Login { get; set; }
        public ICollection<Telefone> Telefones { get; set; }

        public ValidationResult ValidationResult { get; set; }
        public Usuario()
        {
            Telefones = new List<Telefone>();
        }
    }
}
