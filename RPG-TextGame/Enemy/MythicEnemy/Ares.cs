using RPG_TextGame.Functionality;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy;

public class Ares : IEnemy
{
    
    private int enemyHealth = 500;

    private string enemyName = "Ares, God of War";

    private int attackDamage = 40;

    private RarityLevel rarity = RarityLevel.MYTHIC;

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