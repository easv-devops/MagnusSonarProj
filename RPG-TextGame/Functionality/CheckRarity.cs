using System.Drawing;
using Pastel;
using RPG_TextGame.Interface;

namespace RPG_TextGame.Functionality;

public class CheckRarity
{
    public String HandleEnemyRarity<T>(T enemy) where T : IEnemy
    {
        RarityLevel rarityLevel = enemy.getRarity();

        string x = enemy.getName();
        
        
        switch (rarityLevel)
        {
            case RarityLevel.COMMON:

                return x.Pastel(ConsoleColor.Gray);
                
                break;
            case RarityLevel.UNCOMMON:
              
                return x.Pastel(ConsoleColor.Cyan);
                
                break;
            case RarityLevel.RARE:
             
                return x.Pastel(ConsoleColor.Yellow);
                
                break;
            case RarityLevel.MYTHIC:
                
                return x.Pastel(ConsoleColor.Magenta);
                
                break;
            default:
                Console.WriteLine("Unknown RarityLevel.");
                break;
        }

        return "";
    }
    
    public String HandleWeaponRarity<T>(T tool) where T : ITool
    {
        
        
        /*
        switch (rarityLevel)
        {
            case RarityLevel.COMMON:

                return x.Pastel(ConsoleColor.Gray);
                
                break;
            case RarityLevel.UNCOMMON:
              
                return x.Pastel(ConsoleColor.Cyan);
                
                break;
            case RarityLevel.RARE:
             
                return x.Pastel(ConsoleColor.Yellow);
                
                break;
            case RarityLevel.MYTHIC:
                
                return x.Pastel(ConsoleColor.Magenta);
                
                break;
            default:
                Console.WriteLine("Ukendt RarityLevel.");
                break;
        }
        */return "";
    }
    
    
}