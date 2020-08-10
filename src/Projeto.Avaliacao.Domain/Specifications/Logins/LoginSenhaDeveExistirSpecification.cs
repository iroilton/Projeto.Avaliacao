using DomainValidation.Interfaces.Specification;
using Projeto.Avaliacao.Domain.Entities;
using Projeto.Avaliacao.Domain.Interfaces.Repositories;

namespace Projeto.Avaliacao.Domain.Specifications.Logins
{
    public class LoginSenhaDeveExistirSpecification : ISpecification<Login>
    {
        private readonly ILoginRepository _loginRepository;
        public LoginSenhaDeveExistirSpecification(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public bool IsSatisfiedBy(Login entity)
        {
            return _loginRepository.LoginExiste(entity);
        }
    }
}
