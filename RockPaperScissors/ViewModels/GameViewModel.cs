using RockPaperScissors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissors.ViewModels
{
    public class GameViewModel
    {
        //add properties
        //player selection
        //computer selection (randomly generated)
        //result

        public Weapon PlayerSelection { get; set; }
        public Weapon ComputerSelection { get; set; }
        public GameResult Result { get; set; }

        public string PlayerSelectionString { get; set; }
    }
}
