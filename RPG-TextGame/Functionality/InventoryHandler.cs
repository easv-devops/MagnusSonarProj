using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Functionality;

public class InventoryHandler
{
    public void CheckInventory(Player p)
    {
        List<ITool> invenList = p.inv;
        IDictionary<int, ITool> playerInventory = new Dictionary<int, ITool>();

        Console.WriteLine("You have this in your inventory:");
        
        int index = 1;
        
        foreach (ITool t in invenList)
        {
            Console.WriteLine(t.GetName());
            playerInventory.Add(index, t);
            index++;
        }
        
        Console.WriteLine("Do you want to use an item? (yes = y, no = n)..");

        string getAnswer = Console.ReadLine();

        switch (getAnswer)
        {
            case "y":
                
                Console.WriteLine("If you want to use an item, press the number that corresponds to the order in which\n" +
                                  " the items were shown.");

                string userInput = Console.ReadLine();
                int chosenIndex;

                bool isANumber = int.TryParse(userInput, out chosenIndex);

                if (isANumber == true)
                {
                    
                    if (playerInventory.ContainsKey(Convert.ToInt32(userInput)))
                    {
                        ITool tool = playerInventory[Convert.ToInt32(userInput)];
                        tool.Act(p);
                        invenList.Remove(tool);
                        Console.WriteLine("You used an item and healed...");
                    }
                    else
                    {
                        Console.WriteLine("Wrong input... going back to main..");
                    }
                }

                if (isANumber == false)
                {
                    Console.WriteLine("Wrong input mate..");
                }
                
                break;
            case "n":
                Console.WriteLine("Sending you back..");
                break;
            default:
                Console.WriteLine("Wrong input");
                break;
        }
    }
}