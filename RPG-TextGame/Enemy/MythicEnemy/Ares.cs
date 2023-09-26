using RPG_TextGame.Functionality;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Enemy;

public class Ares : IEnemy
{
    
    public int enemyHealth = 500;

    public string enemyName = "Ares, God of War";

    public int attackDamage = 40;

    public RarityLevel rarity = RarityLevel.MYTHIC;
    
    
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