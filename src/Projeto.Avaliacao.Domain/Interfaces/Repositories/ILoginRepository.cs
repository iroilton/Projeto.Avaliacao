using Projeto.Avaliacao.Domain.Entities;

namespace Projeto.Avaliacao.Domain.Interfaces.Repositories
{
    public interface ILoginRepository : IRepositoryBase<Login>
    {
        bool LoginExiste(Login obj);
        bool LoginAtivo(Login obj);
        bool LoginDesbloqueado(Login obj);
        
    }
}
