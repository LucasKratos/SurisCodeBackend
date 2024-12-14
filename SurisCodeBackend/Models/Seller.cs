namespace SurisCodeBackend.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Seller(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }

        public static IEnumerable<Seller> GetList()
        {
            return new List<Seller> {
                new Seller(1, "Hernan Garna"),
                new Seller(2, "Lucas Lauriente"),
                new Seller(3, "Martin Gomez"),
                new Seller(4, "Alan Tellerio"),
                new Seller(5, "Gonzalo Hernandez"),
                new Seller(6, "Ezequiel Martinez")
            };
        }

    }
}
