using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorGame
{
    
    public class AutoPlayer:Player
    {
        
        public string _playerType = "Computer".ToUpper();
              

        public string makeMove()
        {
            string[] playerChoice = new string[] { "Rock", "Paper", "Scissor" };
            Random rand = new Random();
            string choice;
            int p = rand.Next(0, 3);
            choice = playerChoice[p].ToUpper();
            return choice;
           
            
        }


    }
}
