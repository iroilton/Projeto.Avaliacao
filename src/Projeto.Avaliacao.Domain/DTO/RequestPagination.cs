namespace Projeto.Avaliacao.Domain.DTO
{
    public class RequestPagination<T> where T : class
    {
        public RequestPagination()
        {
            PageSize = 10;
        }

        public T Filtro { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }
}
