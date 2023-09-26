using RPG_TextGame.Functionality;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy.CommonEnemy;

public class Peasant : IEnemy
{
    
    public int enemyHealth = 30;

    public string enemyName = "Peasant";

    public int attackDamage = 3;

    public RarityLevel rarity = RarityLevel.COMMON;
    
    
    
    public void Fight(Player p)
    {
        
        
        
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