using RPG_TextGame.Functionality;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy.CommonEnemy;

public class Bandit : IEnemy
{
    private int enemyHealth = 75;

    private string enemyName = "Bandit";

    private int attackDamage = 7;

    private RarityLevel rarity = RarityLevel.COMMON;
    
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