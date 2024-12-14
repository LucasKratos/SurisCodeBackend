using Microsoft.AspNetCore.Mvc;
using SurisCodeBackend.Models;

namespace SurisCodeBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PurchaseOrdersController : ControllerBase
    {
        [HttpPost(Name = "SubmitPurchaseOrder")]
        public IActionResult SubmitOrder([FromBody] PurchaseOrder purchaseOrder)
        {
            try
            {
                ValidateSellerExists(purchaseOrder.Vendedor);
                ValidateArticlesAndTotal(purchaseOrder.Articulos);
            }
            catch (Exception ex)
            {
                return NotFound(new { error = ex.Message });
            }
            return Ok(new { message = "Orden cargada con éxito." });
        }

        private void ValidateSellerExists(int vendedorId)
        {
            if (!Seller.GetList().Any(seller => seller.Id == vendedorId))
            {
                throw new Exception("Vendedor no válido o no encontrado.");
            }
        }

        private void ValidateArticlesAndTotal(List<string> articulos)
        {
            if (!articulos.Any())
            {
                throw new Exception("La Lista de articulos esta vacia.");
            }
            List<string> invalidArticles = articulos
                .Where(a => !Article.GetList().Any(article => article.Codigo == a))
                .Select(a => a)
                .ToList();

            if (invalidArticles.Any())
            {
                throw new Exception($"Artículos inválidos: {string.Join(", ", invalidArticles)}.");
            }
            double totalOrderValue = articulos
                .Sum(a => Article.GetList().First(article => article.Codigo == a).Precio);

            if (totalOrderValue == 0)
            {
                throw new Exception("El total de la orden no puede ser 0.");
            }
        }
    }
}
