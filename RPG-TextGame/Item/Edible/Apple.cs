using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Tool.Edible;

public class Apple : ITool
{
    public String Name = "Apple";

    public int HealthAdd = 20;
    
    public void Act(Player player)
    {
        player.playerHealth = player.playerHealth + HealthAdd;
    }

    public string GetName()
    {
        return Name;
    }
}