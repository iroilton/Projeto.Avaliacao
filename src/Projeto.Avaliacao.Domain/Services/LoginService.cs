using DomainValidation.Validation;
using Projeto.Avaliacao.Domain.Entities;
using Projeto.Avaliacao.Domain.Interfaces.Repositories;
using Projeto.Avaliacao.Domain.Interfaces.Services;
using Projeto.Avaliacao.Domain.Validations.Logins;

namespace Projeto.Avaliacao.Domain.Services
{
    public class LoginService: ServiceBase<Login>, ILoginService
    {
        private readonly ILoginRepository _loginRepository;
        public LoginService(ILoginRepository loginRepository) : base(loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public Login Verificar(Login obj)
        {
            obj.ValidationResult = new LoginEstaConsistenteValidation(_loginRepository).Validate(obj);

            return obj;
        }
    }
}
