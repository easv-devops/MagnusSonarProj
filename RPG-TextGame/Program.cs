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
        Bandit b1 = new Bandit();

        
        // -------
        
        tp.startPrompt();
        
        Player p1 = new Player(Console.ReadLine());
        
        tp.playerWelcomeMessage(p1);

        MenuOptionHandling moh = new MenuOptionHandling();
        
        moh.OptionHandle(p1);

    }
    
}