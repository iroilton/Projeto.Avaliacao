using DomainValidation.Interfaces.Specification;
using Projeto.Avaliacao.Domain.Entities;
using Projeto.Avaliacao.Domain.Interfaces.Repositories;

namespace Projeto.Avaliacao.Domain.Specifications.Logins
{
    public class LoginEstaAtivoSpecification : ISpecification<Login>
    {
        private readonly ILoginRepository _loginRepository;
        public LoginEstaAtivoSpecification(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public bool IsSatisfiedBy(Login entity)
        {
            return _loginRepository.LoginAtivo(entity);
        }
    }
}
