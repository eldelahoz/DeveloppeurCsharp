using Microsoft.AspNetCore.Mvc;
using pizza_hz.Models;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pizza_hz.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        [HttpGet]
        [Route("GetPizzas")]
        public IActionResult GetPizzas()
        {
            Pizza pizza = new Pizza() { nom = "das", ingredients = "dasdas", prix = 8, vegetarienne = false };
            return Json(pizza);
        }
    }
}
