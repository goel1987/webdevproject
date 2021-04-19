using System;
using Microsoft.AspNetCore.Mvc;

namespace WebDevProject.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            //games = new Repository<Game>(ctx);
        }

        public RedirectToActionResult Index() => RedirectToAction("Index", "Home");

        [HttpGet]
        public ViewResult Add()
        {
            LoadViewBag("AddGame");
            return View();
        }

        //[HttpPost]
        //public IActionResult Add(Game g)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (g.gameId == 0)
        //            games.Insert(g);
        //        else
        //            games.Update(g);
        //        games.Save();
        //        return RedirectToAction("Index", "Home");
        //    }
        //    else
        //    {
        //        string operation = (g.GameId == 0) ? "Add" : "Edit";
        //        this.LoadViewBag(operation);
        //        return View();
        //    }
        //}

        [HttpGet]
        public ViewResult Edit(int id)
        {
            this.LoadViewBag("Edit");
            //var g = this.GetGame(id);   .....next line should be: return View("UpdateGame", g);
            return View("UpdateGame");
        }

        //[HttpGet]
        //public ViewResult Delete(int id)
        //{
        //    var g = this.GetGame(id);

        //    return View(g);
        //}

        //[HttpPost]
        //public RedirectToActionResult Delete(Game g)
        //{
        //    games.Delete(c);
        //    games.Save();
        //    return RedirectToAction("Index", "Home");
        //}


        private void LoadViewBag(string operation)
        {
            ViewBag.Operation = operation;
        }
    }
}
