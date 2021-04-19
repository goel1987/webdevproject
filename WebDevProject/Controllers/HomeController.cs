using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebDevProject.Models;

/* Luke Greeley */

namespace WebDevProject.Controllers
{
    public class HomeController : Controller
    {

        private GameContext context { get; set; }
        public HomeController(GameContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var games = context.Games.Include(m => m.Rating).OrderBy(m => m.Name).ToList();
            return View(games);
        }

    }
}
