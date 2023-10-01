using RPG_TextGame.PlayerInformation;
using RPG_TextGame.Tool.Edible;

namespace RPG_TextGame.Functionality;

public class ItemDrop
{
    public void DropItem(Player p)
    {
        Random _random = new Random();
        int num = _random.Next(0, 101);
        

        if (num > 0 && num <= 20)
        {
            Console.WriteLine("Nothing dropped...");
        }
        
        if (num > 20 && num <= 50)
        {
            Apple a = new Apple();
            Console.WriteLine($"{a.GetName()} dropped... do you want to pick it up? (y = yes, n = no)");
            string userInput = Console.ReadLine();
            
            switch (userInput)
            {
                case "y":
                    p.AddToInventory(a);
                    Console.WriteLine($"You picked up the {a.GetName()}..");
                    break;
                case "n":
                    Console.WriteLine($"You let the {a.GetName()} lay there..");
                    break;
                default:
                    Console.WriteLine("Invalid input.. you lost the drop..");
                    break;
            }
        }
        
        if (num > 50 && num <= 75)
        {
            
            Banana b = new Banana();
            Console.WriteLine($"{b.GetName()} dropped... do you want to pick it up? (y = yes, n = no)");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "y":
                    p.AddToInventory(b);
                    Console.WriteLine($"You picked up the {b.GetName()}..");
                    break;
                case "n":
                    Console.WriteLine($"You let the {b.GetName()} lay there..");
                    break;
                default:
                    Console.WriteLine("Invalid input.. you lost the drop..");
                    break;
            }
            
        }
        
        if (num > 80 && num <= 100)
        {
            Console.WriteLine("Nothing dropped...");
        }
    }
}