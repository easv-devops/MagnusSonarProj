using RPG_TextGame.Functionality;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy;

public class ThessalianHoplite : IEnemy
{
    public int enemyHealth = 170;

    public string enemyName = "Thessalian Hoplite";

    public int attackDamage = 20;

    public RarityLevel rarity = RarityLevel.RARE;


    public void Fight(Player p)
    {
        
    }
}