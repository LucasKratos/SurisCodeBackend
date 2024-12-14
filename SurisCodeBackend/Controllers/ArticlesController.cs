using Microsoft.AspNetCore.Mvc;
using SurisCodeBackend.Models;

namespace SurisCodeBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlesController : ControllerBase
    {
        [HttpGet(Name = "GetArticles")]
        public ArticlesResponse Get()
        {
            return new ArticlesResponse(Article.GetList());
        }
    }
}
