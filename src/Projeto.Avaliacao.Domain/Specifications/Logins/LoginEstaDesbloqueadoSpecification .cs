using DomainValidation.Interfaces.Specification;
using Projeto.Avaliacao.Domain.Entities;
using Projeto.Avaliacao.Domain.Interfaces.Repositories;

namespace Projeto.Avaliacao.Domain.Specifications.Logins
{
    public class LoginEstaDesbloqueadoSpecification : ISpecification<Login>
    {
        private readonly ILoginRepository _loginRepository;
        public LoginEstaDesbloqueadoSpecification(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public bool IsSatisfiedBy(Login entity)
        {
            return _loginRepository.LoginDesbloqueado(entity);
        }
    }
}
