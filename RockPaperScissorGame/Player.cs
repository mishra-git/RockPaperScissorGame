using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorGame
{
    public  class  Player
    {
        private  string _playerName;
        private string _playerChoice;

        public  void setPlayerName(string name)
        {
            _playerName = name;

        }
        public  string getPlayerName()
        {
            return _playerName;
        }


        public void setPlayerChoice(string playerChoice)
        {
            _playerChoice = playerChoice;
        }

       
        public string getPlayerChoice()
        {
            return _playerChoice;
        }

    }

}
