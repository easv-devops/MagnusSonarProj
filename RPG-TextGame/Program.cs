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
        
        
        Ares ar = new Ares();

        Commoner c = new Commoner();

        
        
        
        
        Console.WriteLine(cr.HandleEnemyRarity(ar) + " has appeared");


    }  
}