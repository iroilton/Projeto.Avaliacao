using Projeto.Avaliacao.Domain.Entities;
using Projeto.Avaliacao.Domain.Interfaces.Repositories;
using Projeto.Avaliacao.Domain.Interfaces.Services;

namespace Projeto.Avaliacao.Domain.Services
{
    public class TelefoneService : ServiceBase<Telefone>, ITelefoneService
    {
        private readonly ITelefoneRepository _telefoneRepository;
        public TelefoneService(ITelefoneRepository telefoneRepository) : base (telefoneRepository)
        {
            _telefoneRepository = telefoneRepository;
        }
    }
}
