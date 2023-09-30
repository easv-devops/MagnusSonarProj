using RPG_TextGame.Functionality;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy;

public class FootSoldier : IEnemy
{
    public int enemyHealth = 130;

    public string enemyName = "Athenian Foot Soldier";

    public int attackDamage = 10;

    public RarityLevel rarity = RarityLevel.UNCOMMON;
    
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