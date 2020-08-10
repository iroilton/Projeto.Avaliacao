using Projeto.Avaliacao.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Projeto.Avaliacao.Infra.Data.EntityConfig
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            HasKey(u => u.UsuarioID);

            Property(u => u.Nome).IsRequired();
            Property(u => u.Email).IsRequired();
            Property(u => u.CPF).IsRequired();
            Property(u => u.DataNascimento).IsRequired();
            Property(u => u.NomeMae).IsRequired();
            Property(u => u.DataInclusao);
            Property(u => u.DataAlteracao);
            Property(u => u.Ativo).IsRequired();

            HasRequired(u => u.Login)
            .WithRequiredPrincipal(u => u.Usuario);

            Ignore(u => u.ValidationResult);

            ToTable("TBUSUARIOS");
        }
    }
}
