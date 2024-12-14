using Microsoft.AspNetCore.Mvc;
using SurisCodeBackend.Models;

namespace SurisCodeBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 
    public class ArticlesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetArticles()
        {
            try
            {
                var articles = Article.GetList();
                return Ok(new ArticlesResponse(articles));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Error interno del servidor", Error = ex.Message });
            }
        }
    }
}
