using DomainValidation.Validation;
using Projeto.Avaliacao.Domain.Entities;
using Projeto.Avaliacao.Domain.Interfaces.Repositories;
using Projeto.Avaliacao.Domain.Specifications.Logins;

namespace Projeto.Avaliacao.Domain.Validations.Logins
{
    public class LoginEstaConsistenteValidation : Validator<Login>
    {
        public LoginEstaConsistenteValidation(ILoginRepository _loginRepository)
        {
            var loginExiste = new LoginSenhaDeveExistirSpecification(_loginRepository);
            var loginAtivo = new LoginEstaAtivoSpecification(_loginRepository);
            var loginDesbloqueado = new LoginEstaDesbloqueadoSpecification(_loginRepository);

            base.Add("loginExiste", new Rule<Login>(loginExiste, "Login e Senha não são válidos!"));
            base.Add("loginAtivo", new Rule<Login>(loginAtivo, "Login está Inativo!"));
            base.Add("loginDesbloqueado", new Rule<Login>(loginDesbloqueado, "Login está Bloqueado!"));
        }
    }
}
