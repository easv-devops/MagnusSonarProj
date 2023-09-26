using RPG_TextGame.Functionality;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy;

public class SpartanHoplite : IEnemy
{
    public int enemyHealth = 200;

    public string enemyName = "Spartan Hoplite";

    public int attackDamage = 20;

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
}