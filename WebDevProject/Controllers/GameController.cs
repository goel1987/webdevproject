using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDevProject.Models;

namespace WebDevProject.Controllers
{
    public class GameController : Controller
    {
        private GameContext context { get; set; }
        public GameController(GameContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Ratings = context.Ratings.OrderBy(r => r.Name).ToList();
            return View("Edit", new Game());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Ratings = context.Ratings.OrderBy(r => r.Name).ToList();
            var game = context.Games.Find(id);
            return View(game);
        }
        [HttpPost]
        public IActionResult Edit(Game game)
        {
            if (ModelState.IsValid)
            {
                if (game.GameId == 0) context.Games.Add(game);
                else
                    context.Games.Update(game); context.SaveChanges();
                return RedirectToAction("ShowGames", "Home");
            }
            else
            {
                ViewBag.Action = (game.GameId == 0) ? "Add" : "Edit";
                ViewBag.Ratings = context.Ratings.OrderBy(r => r.Name).ToList();
                return View(game);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var game = context.Games.Find(id); return View(game);
        }
        [HttpPost]
        public IActionResult Delete(Game game)
        {
            context.Games.Remove(game); context.SaveChanges();
            return RedirectToAction("ShowGames", "Home");
        }
    }
}
