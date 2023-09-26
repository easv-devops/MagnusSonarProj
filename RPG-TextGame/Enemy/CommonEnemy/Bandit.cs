using RPG_TextGame.Functionality;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy.CommonEnemy;

public class Bandit : IEnemy
{
    public int enemyHealth = 75;

    public string enemyName = "Bandit";

    public int attackDamage = 7;

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