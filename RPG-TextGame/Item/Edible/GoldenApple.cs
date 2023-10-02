using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Tool.Edible;

public class GoldenApple : ITool
{
    public String Name = "Golden Apple";
    
    public int HealthAdd = 45;
    
    public void Act(Player player)
    {
        player.playerHealth = player.playerHealth + HealthAdd;
    }

    public string GetName()
    {
        return Name;
    }
}