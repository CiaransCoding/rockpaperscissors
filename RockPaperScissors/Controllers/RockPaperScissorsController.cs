using Microsoft.AspNetCore.Mvc;
using RockPaperScissors.LogicProviders;
using RockPaperScissors.Models;
using RockPaperScissors.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissors.Controllers
{
    public class RockPaperScissorsController : Controller
    {
        public RockPaperScissorsController()
        {
            this.LogicProvider = new RockPaperScissorsLogicProvider();
        }

        public RockPaperScissorsLogicProvider LogicProvider { get; set; }

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
        public IActionResult Result(string playerSelection)
        {
            Weapon playerSelectionEnum;
            Enum.TryParse(playerSelection, out playerSelectionEnum);

            GameViewModel viewModel = new GameViewModel() 
            { 
                PlayerSelection = playerSelectionEnum,
                ComputerSelection = LogicProvider.GetRandomSelection()
            };

            viewModel.Result = LogicProvider.GetPlayerResult(viewModel.PlayerSelection, viewModel.ComputerSelection);

            return View(viewModel);
        }
    }
}
