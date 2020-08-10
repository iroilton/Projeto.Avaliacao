using AutoMapper;
using Projeto.Avaliacao.Application.ViewModels;
using Projeto.Avaliacao.Domain.DTO;
using Projeto.Avaliacao.Domain.Entities;

namespace Projeto.Avaliacao.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<Usuario, UsuarioLoginTelefoneViewModel>();
            CreateMap<Telefone, UsuarioLoginTelefoneViewModel>();
            CreateMap<Login, UsuarioLoginTelefoneViewModel>();
            CreateMap<Telefone, TelefoneViewModel>();
            CreateMap<Login, LoginViewModel>();
            CreateMap<RequestPagination<Usuario>, RequestPaginationViewModel<UsuarioViewModel>>();
            CreateMap<Paged<Usuario>, PagedViewModel<UsuarioViewModel>> ();
        }
    }
}
