using System;

namespace RockPaperScissorGame
{
    public class RPSGame
    {
       static void Main(string[] args)
        {
            string[] AutoPlayers = new string[] { "Abbacus", "Pentium", "IBM" };
            int ComputerScore=0;
            int HumanScore=0;
           
            Random comprand = new Random();
            int k = comprand.Next(0, 3);
            string compName = AutoPlayers[k].ToUpper();

            Console.WriteLine("Enter Your username:\n");
            string userName = Console.ReadLine().ToUpper();
            Console.WriteLine($"Hello {userName}");
            Console.WriteLine($" I am an old Computer ! My name is {compName} I am so excited to play this game with you {userName}! ");
            
                      
            
            AutoPlayer aplayer = new AutoPlayer();
            aplayer.setPlayerName(compName);

            HumanPlayer hplayer = new HumanPlayer();
            hplayer.setPlayerName(userName);

            do
            {
                
                Console.WriteLine($" {userName} ! How many rounds you want to play this game?");
                string roundChoice = Console.ReadLine();
                int round;
                
                while (!int.TryParse(roundChoice, out round))
                {
                    Console.WriteLine($" {roundChoice} is not a number!. Please Enter your choice as number \n");
                    roundChoice = Console.ReadLine();
                }
                Console.WriteLine("Let us begin !!\n ");
                                              

                for (int i = 1; i <= round; i++)
                {
                    aplayer.setPlayerChoice(aplayer.makeMove());
                    hplayer.setPlayerChoice(hplayer.makeMove());
                    Console.WriteLine($" You --> [ {hplayer.getPlayerName()}] Picked  {hplayer.getPlayerChoice()}\n");
                    Console.WriteLine($"I--> [{aplayer.getPlayerName()}] picked {aplayer.getPlayerChoice()}\n");
                   
                    GamePlay play = new GamePlay();
                    string returnValue = play.playGame(hplayer, aplayer);

                    if (returnValue == "HUMAN")
                    {
                        Console.WriteLine($" {hplayer.getPlayerName()} ! You just beat me up in this round {i} ");
                    }
                    else if (returnValue == "COMPUTER")
                    {
                        Console.WriteLine($" I - {aplayer.getPlayerName()} am beating you up {hplayer.getPlayerName()} in this round {i} ! but dont feel bad yet ! ");

                    }

                    else
                    {
                        Console.WriteLine($" Oh , HAHA !! , we just seem to pick the same thing in this round {i},  we have a   {returnValue}");

                    }


                        switch (returnValue)
                    {
                        case "HUMAN":
                            HumanScore++;
                            
                            break;
                        case "COMPUTER":
                            ComputerScore++;
                           
                            break;

                        default:
                            break;

                    }

                }
                Console.WriteLine("****" + " END OF THE ROUNDS"  + " *****\n");
                Console.WriteLine("......Wait until your computer analyses the data to determine the winner....\n "); 
                System.Threading.Thread.Sleep(4600);
                Console.WriteLine("*****Yay ! Result is ready *****\n ");

                Console.WriteLine("****" + " GAME SUMMARY" + " *****\n");
               
                Console.WriteLine($" {hplayer.getPlayerName()} scored  {HumanScore} ");
                Console.WriteLine($" {aplayer.getPlayerName()} scored  {ComputerScore} ");

                if(HumanScore>ComputerScore)
                {
                    Console.WriteLine($" {hplayer.getPlayerName()} ! You  won the game with a score of {HumanScore} while I have scored only {ComputerScore} ");

                }

               else if (HumanScore < ComputerScore)
                {
                    Console.WriteLine($" {hplayer.getPlayerName()} ! I won this game with a score of {ComputerScore} while You scored only {HumanScore} ");

                }

                else
                {
                    Console.WriteLine($" We are playing neck and neck {hplayer.getPlayerName()} ! we have a tie with  {ComputerScore}  and your score {HumanScore} ");
                }


              Console.WriteLine("Do you want to play again? y/n");
            } while (Console.ReadKey().Key == ConsoleKey.Y);

        }

    }
}
