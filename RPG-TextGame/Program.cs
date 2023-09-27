using RPG_TextGame.Enemy;
using RPG_TextGame.Enemy.CommonEnemy;
using RPG_TextGame.Functionality;
using RPG_TextGame.InheritanceModel;
using RPG_TextGame.Interface;
using RPG_TextGame.Material.Ore;
using RPG_TextGame.PlayerInformation;
using RPG_TextGame.Tool.Edible;

namespace RPG_TextGame;

public class Program 
{  
    public static void Main()
    {
        CheckRarity cr = new CheckRarity();
        TextPromt tp = new TextPromt();

        
        
        // -------
        
        //tp.startPrompt();

        //string x = Console.ReadLine(); 
        
        //tp.playerWelcomeMessage(x);
        //Player _player = new Player(x);



        Player p1 = new Player("Cyraios");
        Bandit b1 = new Bandit();
        
        
        b1.Fight(p1);
        


    }
    
}