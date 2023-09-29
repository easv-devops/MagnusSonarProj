using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Functionality;

public class MenuOptionHandling
{
    
    
    public void HandleMainMenuChoice(string option, Player p)
    {
        switch (option)
        {
            case "m":
                MovePlayer(p);
                break;
            case "i":
                SeeInventory(p);
                break;
            case "p":
                SeeStats(p);
                break;
            case "q":
                Exit();
                break;
            default:
                Console.WriteLine("Press a valid button");
                break;
        }
    }
    
    
    public void MovePlayer(Player p)
    {
     
        KeepGoing();
    }
    
    public void SeeInventory(Player p)
    {
        
    }
    
    public void SeeStats(Player p)
    {
        Console.WriteLine($"{p.playerName}: Has {p.playerHealth} health, lvl: {p.playerLevel} and is currently at {p.wl}");
    }
    
    public void KeepGoing()
    {
        Console.WriteLine("\nPress a key to make a move");
        Console.ReadKey();
    }
    
    
}