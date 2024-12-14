using Microsoft.AspNetCore.Mvc;
using SurisCodeBackend.Models;

namespace SurisCodeBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SellersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSellers()
        {
            try
            {
                var sellers = Seller.GetList();
                return Ok(new SellersResponse(sellers));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Error interno del servidor", Error = ex.Message });
            }
        }
    }
}
