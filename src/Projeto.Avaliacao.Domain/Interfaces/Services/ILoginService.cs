using DomainValidation.Validation;
using Projeto.Avaliacao.Domain.Entities;

namespace Projeto.Avaliacao.Domain.Interfaces.Services
{
    public interface ILoginService : IServiceBase<Login>
    {
        Login Verificar(Login obj);
    }
}
