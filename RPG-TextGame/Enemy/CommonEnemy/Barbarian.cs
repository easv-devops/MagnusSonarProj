using RPG_TextGame.Functionality;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy.CommonEnemy;

public class Barbarian : IEnemy
{
    private int enemyHealth = 60;

    private string enemyName = "Barbarian";

    private int attackDamage = 5;

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