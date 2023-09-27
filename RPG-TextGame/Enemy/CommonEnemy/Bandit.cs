using RPG_TextGame.Functionality;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy.CommonEnemy;

public class Bandit : IEnemy
{
    public int enemyHealth = 75;

    public string enemyName = "Bandit";

    public int attackDamage = 7;

    public RarityLevel rarity = RarityLevel.COMMON;


    public void Fight(Player p)
    {
        Console.WriteLine("A battle has been initiated.\n");
        
        while (enemyHealth > 0 && p.playerHealth > 0)
        {
            
            Console.WriteLine($"It's your turn to strike. You deal {p.playerDamage} damge.");
            
            enemyHealth = enemyHealth - p.playerDamage;
            
            if (enemyHealth <= 0)
            {
                Console.WriteLine($"{enemyName} falls over.");
                break;
            }
            Console.WriteLine($"Enemy has {enemyHealth} health left. His turn to strike has come. He deals {attackDamage} damage.");
            
            
            p.playerHealth = p.playerHealth - attackDamage;

            if (p.playerHealth <= 0)
            {
                Console.WriteLine($"{p.playerName} falls over.");
                break;
            }

            Console.WriteLine($"You have {p.playerHealth} health left.");
            
        }
        
        if (p.playerHealth <= 0)
        {
            Console.WriteLine($"{p.playerName} has been slain by {enemyName}. Better luck next time.");
        }
        
        if (enemyHealth <= 0)
        {
            Console.WriteLine($"{p.playerName} has slain {enemyName}. Good job.");
        }
        
    }

    public RarityLevel getRarity()
    {
        return rarity;
    }

    public string getName()
    {
        return enemyName;
    }
}