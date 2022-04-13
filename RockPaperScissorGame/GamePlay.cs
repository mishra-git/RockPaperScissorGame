using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorGame
{
    public class GamePlay
    {
        public string winner;
             

        public bool hasWon(HumanPlayer hplayer, AutoPlayer aplayer)
        {
            return (
                (aplayer.getPlayerChoice() == "rock".ToUpper() && hplayer.getPlayerChoice() == "scissors".ToUpper()) ||
                (aplayer.getPlayerChoice() == "scissors".ToUpper() && hplayer.getPlayerChoice() == "paper".ToUpper()) ||
                (aplayer.getPlayerChoice() == "paper".ToUpper() && hplayer.getPlayerChoice() == "rock".ToUpper())
                );
        }

       
        public string playGame(HumanPlayer hplayer, AutoPlayer aplayer)
        {
            if (hplayer.getPlayerChoice() == "ROCK" && aplayer.getPlayerChoice() == "SCISSOR")
            {
               
                winner = hplayer._playerType;
            }
            else if (hplayer.getPlayerChoice() == "ROCK" && aplayer.getPlayerChoice() == "PAPER")
            {
                
                winner = aplayer._playerType;

            }
            else if (hplayer.getPlayerChoice() == "PAPER" && aplayer.getPlayerChoice() == "ROCK")
            {
                
                winner = hplayer._playerType;

            }
            else if (hplayer.getPlayerChoice() == "PAPER" && aplayer.getPlayerChoice() == "SCISSOR")
            {
                
                winner = aplayer._playerType;

            }
            else if (hplayer.getPlayerChoice() == "SCISSOR" && aplayer.getPlayerChoice() == "ROCK")
            {
                
                winner = aplayer._playerType;
            }
            else if (hplayer.getPlayerChoice() == "SCISSOR" && aplayer.getPlayerChoice() == "PAPER")
            {
                
                winner = hplayer._playerType;
            }
            else
            {
                winner = "Tie".ToUpper();
            }


            return winner;





        }
    }
}




