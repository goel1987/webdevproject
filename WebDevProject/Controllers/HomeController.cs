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
            return View("Index");
        }

        public IActionResult About()
        {
            return View("About");
        }
        public IActionResult ShowGames()
        {
            var games = context.Games.Include(g => g.Rating).OrderBy(g => g.Name).ToList();
            return View(games);
        }

    }
}
