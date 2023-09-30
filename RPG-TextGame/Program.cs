using RPG_TextGame.Enemy;
using RPG_TextGame.Enemy.CommonEnemy;
using RPG_TextGame.Functionality;
using RPG_TextGame.InheritanceModel;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;
using RPG_TextGame.Tool.Edible;

namespace RPG_TextGame;

public class Program 
{  
    public static void Main()
    {
        //MenuOptionHandling moh = new MenuOptionHandling();
        
        //moh.OptionHandle();

        Player p1 = new Player("Magnus");
        Bandit b1 = new Bandit();



        CombatHandler ch = new CombatHandler();
        
        
        ch.Fight(b1, p1);
        








    }
    
}