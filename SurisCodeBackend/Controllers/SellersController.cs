using Microsoft.AspNetCore.Mvc;
using SurisCodeBackend.Models;

namespace SurisCodeBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SellersController : ControllerBase
    {
        [HttpGet(Name = "GetSellers")]
        public SellersResponse Get()
        {
            return new SellersResponse(Seller.GetList());
        }
    }
}
