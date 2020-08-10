using Projeto.Avaliacao.Domain.Entities;
using Projeto.Avaliacao.Domain.Interfaces.Repositories;
using Projeto.Avaliacao.Infra.Data.Context;
using System.Linq;

namespace Projeto.Avaliacao.Infra.Data.Repositories
{
    public class LoginRepository : RepositoryBase<Login>, ILoginRepository
    {
        public LoginRepository(PrincipalDbContext context) : base(context)
        {

        }

        public bool LoginExiste(Login obj)
        {
            return Db.Logins.Any(l => (l.LoginUsuario == obj.LoginUsuario && l.Senha == obj.Senha));
        }

        public bool LoginAtivo(Login obj)
        {
            return Db.Logins.Any(l => l.LoginUsuario == obj.LoginUsuario && l.Senha == obj.Senha && l.Ativo);
        }

        public bool LoginDesbloqueado(Login obj)
        {
            return Db.Logins.Any(l => l.LoginUsuario == obj.LoginUsuario && !l.Bloqueado);
        }
    }
}
