using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pizza_hz.Data;
using pizza_hz.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pizza_hz.Pages
{
    public class MenuPizzasModel : PageModel
    {
        private readonly DataContext _dataContext;

        public MenuPizzasModel(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IList<Pizza> Pizza { get; set; }
        public async Task OnGetAsync()
        {
            Pizza = await _dataContext.Pizzas.ToListAsync();
            Pizza = Pizza.OrderBy(p => p.prix).ToList();
        }
    }
}
