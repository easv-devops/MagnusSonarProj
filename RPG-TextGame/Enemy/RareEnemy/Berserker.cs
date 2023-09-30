using RPG_TextGame.Functionality;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy;

public class Berserker : IEnemy
{
    private int enemyHealth = 180;

    private string enemyName = "Berserker";

    private int attackDamage = 25;

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