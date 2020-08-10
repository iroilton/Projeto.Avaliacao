using Projeto.Avaliacao.Domain.DTO;
using Projeto.Avaliacao.Domain.Entities;
using Projeto.Avaliacao.Domain.Interfaces.Repositories;
using Projeto.Avaliacao.Infra.Data.Context;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;

namespace Projeto.Avaliacao.Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(PrincipalDbContext context) : base(context)
        {
        }

        public new Usuario RetornarPorId(int id)
        {
            var usuario = (from u in Db.Usuarios
             where u.UsuarioID == id
             select u).Include(u => u.Login).Include(u => u.Telefones).FirstOrDefault();

            return usuario;
        }
        public Paged<Usuario> RetornarTodosPaginado(RequestPagination<Usuario> obj)
        {
            var usuariosPaginado = (from u in Db.Usuarios
                                    where u.Ativo
                                    select u);
            var result = usuariosPaginado.Include(u => u.Login).OrderBy(o => o.Nome).Skip((obj.PageNumber - 1) * obj.PageSize).Take(obj.PageSize);
            var count = usuariosPaginado.Count();

            return new Paged<Usuario>() { List = result, Count = count, PageNumber = obj.PageNumber };
        }

        public Paged<Usuario> BuscarUsuariosPaginado(RequestPagination<Usuario> obj)
        {
            var query = (from u in Db.Usuarios
                         join l in Db.Logins on u.UsuarioID equals l.LoginID
                         where u.Ativo == obj.Filtro.Ativo || (
                               (!string.IsNullOrEmpty(obj.Filtro.Nome) && u.Nome.Contains(obj.Filtro.Nome)) ||
                               (!string.IsNullOrEmpty(obj.Filtro.CPF) && u.CPF.Contains(obj.Filtro.CPF)) ||
                               (obj.Filtro.DataNascimento != null  && u.DataNascimento.Equals(obj.Filtro.DataNascimento))) ||
                               (!string.IsNullOrEmpty(obj.Filtro.Login.LoginUsuario) && l.LoginUsuario.Contains(obj.Filtro.Login.LoginUsuario))
                         select u);

            var usuarios = query.Include(u => u.Login).OrderBy(o => o.Nome).Skip((obj.PageNumber - 1) * obj.PageSize).Take(obj.PageSize);

            var usuariosCont = query.Count();

            return new Paged<Usuario>() { List = usuarios, Count = usuariosCont, PageNumber = obj.PageNumber, Filtro = obj.Filtro };
        }

        public new void Remover(Usuario obj)
        {
            var usuario = (from u in Db.Usuarios
                          where u.UsuarioID == obj.UsuarioID
                          select u).FirstOrDefault();

            usuario.Ativo = false;

            Db.SaveChanges();
        }

        public void ExcluirTodosUsuarios()
        {
            var usuario = (from u in Db.Usuarios
                           select u);

            foreach (var usu in usuario)
            {
                usu.Ativo = false;
            }       

            Db.SaveChanges();
        }

        public new Usuario Atualizar(Usuario obj)
        {
            var usuario = Db.Usuarios.Single(u => u.UsuarioID == obj.UsuarioID);

            usuario.Ativo = obj.Ativo;
            usuario.CPF = obj.CPF;
            usuario.DataNascimento = obj.DataNascimento;
            usuario.Email = obj.Email;
            usuario.Login = obj.Login;
            usuario.Nome = obj.Nome;
            usuario.NomeMae = obj.NomeMae;

            Db.SaveChanges();

            return obj;
        }
    }
}
