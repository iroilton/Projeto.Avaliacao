namespace Projeto.Avaliacao.Domain.Entities
{
    public class Telefone
    {
        public int TelefoneID { get; set; }
        public int UsuarioID { get; set; }
        public string Fone { get; set; }
        public bool Ativo { get; set; }
        public Usuario Usuario { get; set; }

    }
}
