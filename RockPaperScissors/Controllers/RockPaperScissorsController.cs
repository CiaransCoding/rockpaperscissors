using Microsoft.AspNetCore.Mvc;
using RockPaperScissors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissors.Controllers
{
    public class RockPaperScissorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Leaderboard()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Result()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(Weapon choice)
        {
            return View();
        }
    }
}
