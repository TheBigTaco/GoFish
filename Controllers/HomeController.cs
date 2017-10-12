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
        Game.StartGame(int.Parse(Request.Form["player-amount"]));
        List<Player> players = new List<Player>{};
        for (int i = 0; i < int.Parse(Request.Form["player-amount"]); i++)
        {
          Player player = Player.Find(i);
          players.Add(player);
        }

        return View(players);
      }
    }
}
