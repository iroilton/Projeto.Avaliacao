namespace Projeto.Avaliacao.Application.ViewModels
{
    public class RequestPaginationViewModel<T> where T : class
    {
        public RequestPaginationViewModel()
        {
            PageSize = 10;
        }
        public int PageSize { get; set; }
        public T Filtro { get; set; }        
        public int PageNumber { get; set; }
    }
}
