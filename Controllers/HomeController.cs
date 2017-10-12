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
        Card.DeckGenerator();
        List<Card> playerHand = Card.DrawHand();
        return View(playerHand);
      }
    }
}
