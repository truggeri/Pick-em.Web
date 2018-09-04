using System.Data;
using Microsoft.AspNetCore.Mvc;
using Pick_em.Lib.Data;

namespace Pick_em.Web.Controllers
{
    public class OkController : Controller
    {
        private DatabaseUtils dbUtils { get; set; }

        public OkController(DatabaseUtils givenUtils)
        {
            this.dbUtils = givenUtils;
        }

        [HttpGet("/ok")]
        public IActionResult SimpleOk()
        {
            return Ok("ok");
        }

        [HttpGet("/health/db")]
        public IActionResult DbHealth()
        {
            string health = this.dbUtils.HealthCheck();
            return Ok($"{health}");
        }
    }
}