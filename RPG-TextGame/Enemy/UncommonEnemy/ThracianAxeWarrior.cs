using RPG_TextGame.Functionality;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy;

public class ThracianAxeWarrior : IEnemy
{
    private int enemyHealth = 120;

    private string enemyName = "Thracian Axe Warrior";

    private int attackDamage = 15;

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