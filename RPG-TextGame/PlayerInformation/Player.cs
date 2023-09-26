using RPG_TextGame.Interface;

namespace RPG_TextGame.PlayerInformation;

public class Player
{

    public int playerHealth = 100;
    public List<InheritanceModel.Tool> inv = new List<InheritanceModel.Tool>();
    public String playerName;
    public List<IWeapon> equipped = new List<IWeapon>();
    
    

    public Player(String pName)
    {
        this.playerName = pName;
    }

    public void AddToInventory(InheritanceModel.Tool t)
    {
        inv.Add(t);
    }
    
    public void RemoveFromInventory(InheritanceModel.Tool t)
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
    
}