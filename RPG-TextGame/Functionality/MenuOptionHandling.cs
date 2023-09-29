using RPG_TextGame.PlayerInformation;
using RPG_TextGame.World;

namespace RPG_TextGame.Functionality;

public class MenuOptionHandling
{

    public void OptionHandle(Player p)
    {
        bool going = true;

        while (going == true)
        {
            string userInput = Console.ReadLine();
            
            HandleMainMenuChoice(userInput, p);
        }
    }
    
    public void HandleMainMenuChoice(string? option, Player p)
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
        switch (p.wl)
        {
            case WorldLocation.START:
                p.wl = WorldLocation.ROAD;
                Console.WriteLine($"You have moved to {p.wl}");
                break;
            case WorldLocation.ROAD:
                p.wl = WorldLocation.CITY;
                Console.WriteLine($"You have moved to {p.wl}");
                break;
            case WorldLocation.CITY:
                p.wl = WorldLocation.CAVE;
                Console.WriteLine($"You have moved to {p.wl}");
                break;
            default:
                Console.WriteLine("You are at the end of the road");
                break;
        }
    }
    
    public void SeeInventory(Player p)
    {
        Console.WriteLine($"{p.inv}");
        KeepGoing();
    }
    
    public void SeeStats(Player p)
    {
        Console.WriteLine($"{p.playerName}: Has {p.playerHealth} health, lvl: {p.playerLevel} and is currently at {p.wl}");
        KeepGoing();
    }
    
    public void KeepGoing()
    {
        Console.WriteLine("\nPress a key to make a move");
        Console.ReadKey();
    }

    public void Exit()
    {
        
    }
    
    
}