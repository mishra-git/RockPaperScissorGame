# RockPaperScissorGame
This game is created to reinforce the learning per BESE program in areas of C# general syntax  and Object oriented Programming Concepts 

# Main Classes 
- Public class  Player
  **Has two private properties**
   private  string _playerName;
   private string _playerChoice;
  
 **Has public methods as** 
 public  void setPlayerName(string name)
 public  void getPlayerName
 public void setPlayerChoice(string playerChoice)
 public void setPlayerChoice()
 
 ***
 - Public class  HumanPlayer:Player
  This class represents the human player .
  It has a public property - > 
    public string _playerType = "Human".ToUpper();
 
  It has a public method - >public string makeMove() -- This is for invoking the option choosing among rock, paper, scissor etc 
 **It inherits the methods and properties of the Player Class**
 
 **
  
 - Public Class AutoPlayer:Player
  This class represents the Auto Player - computer player with random names  . 
  It has a public  property of **_playerType** -- public string _playerType = "Computer".ToUpper();
  It has a public method - >public string makeMove() -- This is for invoking the option choosing among rock, paper, scissor etc (random choice) 
  **This class inherits the other methods and properties from **Plyaer** Class**
 
 
 - PlayGame Class 
  This class mainly has the method for playing the game 
  - public bool hasWon(HumanPlayer hplayer, AutoPlayer aplayer)
  - public string playGame(HumanPlayer hplayer, AutoPlayer aplayer)--retuns the winner 
  - 
 
 - RPSGame.Cs file or public class RPSGame
    This class has the main methods to wrap up everytihng 
    
    
    # What featurs have been used ? 
    Well I have gone through the C# general course and OOPS general recommended course  and have tried to 
    - implement the main c# basics conecepts like loops, prints , variables etc 
    - I believe I have explored organizing code and reusability in general 
    - I have explored the Inheritance a little 
    - Polymorphism and Interfaces are somethign I have been thinking to implement but my head is not going to the right direction as of now 
    
    **Any Review from the SME's would be highly appreciated. This will help me keep track and also allow me to think it more on the conectps covered
    
    

