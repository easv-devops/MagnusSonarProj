using RPG_TextGame.Functionality;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy;

public class ThessalianHoplite : IEnemy
{
    private int enemyHealth = 170;

    private string enemyName = "Thessalian Hoplite";

    private int attackDamage = 20;

    private RarityLevel rarity = RarityLevel.RARE;
    

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