using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorGame
{
    public class HumanPlayer:Player
    {
        public string _playerType = "Human".ToUpper();
        
        public string makeMove()
        {
          string choice;
            do
            {
               Console.WriteLine($" Type your choice as either [rock, paper , scissor]\n");
               choice = Console.ReadLine().ToUpper();
            
            } while (choice != "ROCK" && choice != "PAPER" && choice !="SCISSOR");
            return choice;
        }
    }
}
