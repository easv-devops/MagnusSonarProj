using RPG_TextGame.Functionality;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy.CommonEnemy;

public class Barbarian
{
    public int enemyHealth = 60;

    public string enemyName = "Barbarian";

    public int attackDamage = 5;

    public RarityLevel rarity = RarityLevel.COMMON;


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
}