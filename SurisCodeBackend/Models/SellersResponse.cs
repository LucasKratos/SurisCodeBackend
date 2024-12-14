namespace SurisCodeBackend.Models
{
    public class SellersResponse
    {
        public IEnumerable<Seller> Vendedores { get; set; }
        public SellersResponse(IEnumerable<Seller> vendedores)
        {
            Vendedores = vendedores;
        }
    }
}
