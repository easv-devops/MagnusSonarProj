using RPG_TextGame.Functionality;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy;

public class GreekMercenary : IEnemy
{
    public int enemyHealth = 150;

    public string enemyName = "Greek Mercenary";

    public int attackDamage = 12;

    public RarityLevel rarity = RarityLevel.UNCOMMON;
    
    
    
    public void Fight(Player p)
    {
        string userInput = Console.ReadLine();

        switch (userInput)
        {
            case "y":
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
                    p.LevelUp();
                }
                break;
            
            case "n":
                Console.WriteLine("You denied the fight. You can hear laughing coming from the heaven. The Gods are laughing at your cowardice.");
                break;
            default:
                Console.WriteLine("Invalid key...");
                break;
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
    
    public int getDamage()
    {
        return attackDamage;
    }

    public int getHealth()
    {
        return enemyHealth;
    }
    
    
}