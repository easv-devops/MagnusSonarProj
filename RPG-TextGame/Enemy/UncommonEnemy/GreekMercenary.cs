using RPG_TextGame.Functionality;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy;

public class GreekMercenary : IEnemy
{
    public int enemyHealth = 150;

    public string enemyName = "Greek Mercenary";

    public int attackDamage = 12;

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
}