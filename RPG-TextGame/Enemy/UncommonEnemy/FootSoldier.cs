using RPG_TextGame.Functionality;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy;

public class FootSoldier : IEnemy
{
    private int enemyHealth = 130;

    private string enemyName = "Athenian Foot Soldier";

    private int attackDamage = 10;

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