using AutoMapper;
using Projeto.Avaliacao.Application.ViewModels;
using Projeto.Avaliacao.Domain.DTO;
using Projeto.Avaliacao.Domain.Entities;

namespace Projeto.Avaliacao.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<UsuarioViewModel, Usuario>();
            CreateMap<UsuarioLoginTelefoneViewModel, Usuario>();
            CreateMap<UsuarioLoginTelefoneViewModel, Telefone>();
            CreateMap<UsuarioLoginTelefoneViewModel, Login>();
            CreateMap<TelefoneViewModel, Telefone> ();
            CreateMap<LoginViewModel, Login>();
            CreateMap<RequestPaginationViewModel<UsuarioViewModel>, RequestPagination<Usuario>>();
            CreateMap<PagedViewModel<UsuarioViewModel>, Paged<Usuario>>();
        }
    }
}
