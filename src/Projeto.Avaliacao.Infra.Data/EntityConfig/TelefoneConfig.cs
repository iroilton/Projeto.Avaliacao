using Projeto.Avaliacao.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Projeto.Avaliacao.Infra.Data.EntityConfig
{
    public class TelefoneConfig : EntityTypeConfiguration<Telefone>
    {
        public TelefoneConfig()
        {
            HasKey(t => t.TelefoneID);

            Property(t => t.Fone).IsRequired();
            Property(t => t.UsuarioID).IsRequired();
            Property(t => t.Ativo).IsRequired();

            HasRequired(t => t.Usuario)
                .WithMany(u => u.Telefones)
                .HasForeignKey(t => t.UsuarioID);

            ToTable("TBTELEFONES");
        }
    }
}
