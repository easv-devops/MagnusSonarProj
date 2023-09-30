using RPG_TextGame.Enemy;
using RPG_TextGame.Enemy.CommonEnemy;
using RPG_TextGame.PlayerInformation;
using RPG_TextGame.Tool.Edible;
using RPG_TextGame.World;

namespace RPG_TextGame.Functionality;

public class MenuOptionHandling
{

    public void OptionHandle()
    {
        bool going = true;
        
        TextPromt tp = new TextPromt();
        
        tp.startPrompt();
        
        Player p1 = new Player(Console.ReadLine());
        
        tp.playerWelcomeMessage(p1);
        
        
        while (going == true)
        {
            string userInput = Console.ReadLine();
            
            HandleMainMenuChoice(userInput, p1);
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
            case "b":
                MovePlayerBack(p);
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
                SpawnEnemies(p);
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
    
    public void MovePlayerBack(Player p)
    {
        switch (p.wl)
        {
            case WorldLocation.START:
                Console.WriteLine("You cannot move back any further.");
                break;
            case WorldLocation.ROAD:
                p.wl = WorldLocation.START;
                Console.WriteLine($"You have moved to {p.wl}");
                break;
            case WorldLocation.CITY:
                p.wl = WorldLocation.ROAD;
                Console.WriteLine($"You have moved to {p.wl}");
                break;
            case WorldLocation.CAVE:
                p.wl = WorldLocation.CITY;
                Console.WriteLine($"You have moved to {p.wl}");
                break;
        }
    }
    
    
    
    
    public void SeeInventory(Player p)
    {

        Apple a = new Apple();
        
        p.inv.Add(a);

        string x = p.inv.ToString();
        
        Console.WriteLine($"\n{x}");
        KeepGoing();
    }
    
    public void SeeStats(Player p)
    {
        Console.WriteLine($"\n{p.playerName}: Has {p.playerHealth} health, lvl: {p.playerLevel} and is currently at {p.wl}");
        KeepGoing();
    }
    
    public void KeepGoing()
    {
        Console.WriteLine("\nPress a key to make a move");
        Console.ReadKey();
    }

    public void SpawnEnemies(Player p)
    {
        TextPromt tp = new TextPromt();
        
        
        Random _random = new Random();
        int num = _random.Next(0, 101);
        
        if (p.wl == WorldLocation.ROAD)
        {
            if (num >= 0 && num <= 25)
                Console.WriteLine("No enemies found...");
            if (num > 25 && num <= 60)
            {
                Bandit b1 = new Bandit();
                tp.EnemyHasAppeared(b1);
                b1.Fight(p);
            }
            
            if (num > 60 && num <= 80)
            {
                GreekMercenary gc = new GreekMercenary();
                tp.EnemyHasAppeared(gc);
                gc.Fight(p);
            }
            if (num > 80 && num <= 95)
            {
                SpartanHoplite sh = new SpartanHoplite();
                tp.EnemyHasAppeared(sh);
                sh.Fight(p);
            }
            if (num > 95 && num <= 100)
            {
                Ares ar = new Ares();
                tp.EnemyHasAppeared(ar);
                ar.Fight(p);
            }
            
        }
        
        if (p.wl == WorldLocation.CITY)
        {
            /// ADD COMBAT IN OTHER REGIONS
        }
        
        if (p.wl == WorldLocation.CAVE)
        {
            
        }
        
    }

    
    
    
    
    public void Exit()
    {
        
    }
    
    
}