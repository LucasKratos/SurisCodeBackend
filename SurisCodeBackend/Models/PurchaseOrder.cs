namespace SurisCodeBackend.Models
{
    public class PurchaseOrder
    {
        public int Vendedor { get; set; }
        public List<string> Articulos { get; set; }

        public PurchaseOrder(int vendedor, List<string> articulos)
        {
            Vendedor = vendedor;
            Articulos = articulos;
        }
    }
}
