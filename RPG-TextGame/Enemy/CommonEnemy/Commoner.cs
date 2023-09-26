using RPG_TextGame.Functionality;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy.CommonEnemy;

public class Commoner : IEnemy
{
    public int enemyHealth = 50;

    public string enemyName = "Commoner";

    public int attackDamage = 5;

    public RarityLevel rarity = RarityLevel.COMMON;


    public void Fight(Player p)
    {
        throw new NotImplementedException();
    }
}