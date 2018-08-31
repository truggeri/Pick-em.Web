using Microsoft.AspNetCore.Mvc;

namespace Pick_em.Web.Controllers
{
    public class OkController : Controller
    {
        [HttpGet("/ok")]
        public IActionResult SimpleOk()
        {
            return Ok("ok");
        }
    }
}