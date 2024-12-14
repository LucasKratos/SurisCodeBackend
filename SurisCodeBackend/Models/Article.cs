namespace SurisCodeBackend.Models
{
    public class Article
    {
        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public double Precio { get; set; }

        public int Deposito { get; set; }

        public Article(string codigo, string descripcion, double precio, int deposito)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Precio = precio;
            Deposito = deposito;
        }

        public static IEnumerable<Article> GetList()
        {
            return new List<Article> {
                new Article("K1020", "Colchon Telgo", 10256.12, 1),
                new Article("K1022%%", "Colchon Seally", 18256.12, 4),
                new Article("K1024", "Sommier Telgo", 14256.12, 1),
                new Article("K1026", "Sommier Seally", 13256.12, 1),
                new Article("F1026", "Almohada Seally", 0, 1),
                new Article("F1026", "Almohada Seally", 3250.12, 4),
                new Article("K1024", "Sommier Telgo", 14256.12, 4),
                new Article("K1026", "Sommier Seally", -13256.12, 8),
                new Article("K!°1026", "Sommier Seally", -13256.12, 8)
            };
        }
    }
}
