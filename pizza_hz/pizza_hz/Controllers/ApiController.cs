using Microsoft.AspNetCore.Mvc;
using pizza_hz.Data;
using pizza_hz.Models;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pizza_hz.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        private readonly pizza_hz.Data.DataContext _context;
        public ApiController(DataContext context)
        {

            _context = context;

        }
        [HttpGet]
        [Route("GetPizzas")]
        public IActionResult GetPizzas()
        {
            var Pizzas = _context.Pizzas.ToList();;
            return Json(Pizzas);
        }
    }
}
