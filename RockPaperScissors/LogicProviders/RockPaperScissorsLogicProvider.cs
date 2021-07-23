using RockPaperScissors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissors.LogicProviders
{
    public class RockPaperScissorsLogicProvider
    {
        //generate random selection
        public Weapon GetRandomSelection()
        {
            return Weapon.Paper;
        } 


        //get result
        public GameResult GetPlayerResult(Weapon player, Weapon computer)
        {
            return GameResult.Lose;
        }
    }
}
