using RPG_TextGame.Functionality;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy;

public class Berserker : IEnemy
{
    public int enemyHealth = 180;

    public string enemyName = "Berserker";

    public int attackDamage = 25;

    public RarityLevel rarity = RarityLevel.RARE;


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
    
    public int getDamage()
    {
        return attackDamage;
    }

    public int getHealth()
    {
        return enemyHealth;
    }
}