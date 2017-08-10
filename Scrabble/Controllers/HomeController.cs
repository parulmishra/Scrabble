using Microsoft.AspNetCore.Mvc;
using Scrabble.Models;
using System.Collections.Generic;
using System;

namespace Scrabble.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/score")]
    public ActionResult Score()
    {
      ScrabbleScore src = new ScrabbleScore(Request.Form["word"]);
      return View("Index", src);
    }
  }
}
