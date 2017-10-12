using Microsoft.AspNetCore.Mvc;
using System;
using GoFish.Models;
using System.Collections.Generic;

namespace GoFish.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
      [HttpPost("/start")]
      public ActionResult StartGame()
      {
        Game.DeckGenerator();
        Game.StartGame(int.Parse(Request.Form["player-amount"]));
        Player player = Player.Find(1);

        return View(player.GetHand());
      }
    }
}
