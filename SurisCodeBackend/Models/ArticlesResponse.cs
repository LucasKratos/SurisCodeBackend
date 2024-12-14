namespace SurisCodeBackend.Models
{
    public class ArticlesResponse
    {
        public IEnumerable<Article> Articulos { get; set; }

        public ArticlesResponse(IEnumerable<Article> articulos)
        {
            Articulos = articulos;
        }
    }
}
