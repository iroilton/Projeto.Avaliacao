using Projeto.Avaliacao.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Projeto.Avaliacao.Infra.Data.EntityConfig
{
    public class LoginConfig : EntityTypeConfiguration<Login>
    {
        public LoginConfig()
        {
            HasKey(l => l.LoginID);

            Property(l => l.LoginUsuario).HasColumnName("Login").IsRequired();
            Property(l => l.Senha).IsRequired();
            Property(l => l.Ativo).IsRequired();
            Property(l => l.Bloqueado).IsRequired();

            Ignore(l => l.ValidationResult);
           
            ToTable("TBLOGINS");

        }
    }
}
