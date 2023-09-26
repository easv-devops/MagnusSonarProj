using RPG_TextGame.Functionality;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy;

public class Zeus : IEnemy
{
    public int enemyHealth = 500;

    public string enemyName = "Zeus, God of Gods";

    public int attackDamage = 50;

    public RarityLevel rarity = RarityLevel.MYTHIC;
    
    
    public void Fight(Player p)
    {
        
    }
}