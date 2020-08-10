using System.Collections.Generic;

namespace Projeto.Avaliacao.Domain.DTO
{
    public class Paged<T> where T : class
    {
        public Paged()
        {
            PageSize = 10;
        }
        public IEnumerable<T> List { get; set; }
        public int Count { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public T Filtro { get; set; }
    }
}
