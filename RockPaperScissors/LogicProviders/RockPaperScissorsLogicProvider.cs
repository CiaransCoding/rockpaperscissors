using RockPaperScissors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissors.LogicProviders
{
    public class RockPaperScissorsLogicProvider
    {
        public Weapon GetRandomSelection()
        {
            Array values = Enum.GetValues(typeof(Weapon));
            Random random = new Random();
            Weapon randomSelection = (Weapon)values.GetValue(random.Next(values.Length));

            return randomSelection;
        } 


        public GameResult GetPlayerResult(Weapon playerSelection, Weapon computerSelection)
        {
            if (playerSelection.Equals(computerSelection))
            {
                return GameResult.Draw;
            }

            if(playerSelection == Weapon.Rock && computerSelection == Weapon.Paper)
            {
                return GameResult.Lose;
            }
            else if(playerSelection == Weapon.Scissors && computerSelection == Weapon.Rock)
            {
                return GameResult.Lose;
            } 
            else if(playerSelection == Weapon.Paper && computerSelection == Weapon.Scissors)
            {
                return GameResult.Lose;
            }

            return GameResult.Win;
        }
    }
}
