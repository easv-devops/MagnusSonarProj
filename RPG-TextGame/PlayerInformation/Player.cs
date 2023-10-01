using RPG_TextGame.Interface;
using RPG_TextGame.World;

namespace RPG_TextGame.PlayerInformation;

public class Player
{

    public int playerHealth = 100;
    public List<ITool> inv = new List<ITool>();
    public String playerName;
    public int playerDamage = 40;
    public int playerLevel = 1;
    public List<IWeapon> equipped = new List<IWeapon>();
    public WorldLocation wl = WorldLocation.START;
    
    

    public Player(String pName)
    {
        this.playerName = pName;
    }

    public void AddToInventory(ITool t)
    {
        inv.Add(t);
    }
    
    public void RemoveFromInventory(ITool t)
    {
        inv.Remove(t); // Fix this
    }
    
    public void Equip(IWeapon weapon)
    {
        equipped.Add(weapon);
    }
    
    public void UnEquip(IWeapon weapon)
    {
        equipped.Remove(weapon);
    }

    public void LevelUp()
    {
        playerLevel = playerLevel + 1;
    }

    public bool IsDead()
    {
        if (playerHealth == 0)
        {
            return true;
        }

        return false;
    }

    public void IncreaseDamage()
    {
        playerDamage = playerDamage + 5;
    }
    
    
}