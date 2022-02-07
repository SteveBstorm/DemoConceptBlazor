using DemoConcept.Server.Models;
using DemoConcept.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoConcept.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Article> GetAll()
        {
            return ArticleService.ListeArticle.ToArray();
        }
    }
}
