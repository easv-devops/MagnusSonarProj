using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy;

public class Spartan : IEnemy
{
    public int enemyHealth = 200;

    public string enemyName = "Spartan";

    public int attackDamage = 20;

    public int enemyRarity = 2;


    public void Fight(Player p)
    {
        
    }
}