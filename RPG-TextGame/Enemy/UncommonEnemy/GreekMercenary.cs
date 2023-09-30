using RPG_TextGame.Functionality;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy;

public class GreekMercenary : IEnemy
{
    private int enemyHealth = 150;

    private string enemyName = "Greek Mercenary";

    private int attackDamage = 12;

    private RarityLevel rarity = RarityLevel.UNCOMMON;

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