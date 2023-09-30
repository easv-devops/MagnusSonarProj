using RPG_TextGame.Functionality;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy;

public class ThracianAxeWarrior : IEnemy
{
    public int enemyHealth = 120;

    public string enemyName = "Thracian Axe Warrior";

    public int attackDamage = 15;

    public RarityLevel rarity = RarityLevel.UNCOMMON;
    
    
    
    public void Fight(Player p)
    {
        throw new NotImplementedException();
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