using System.Drawing;
using System.Net.NetworkInformation;
using Pastel;
using RPG_TextGame.Interface;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Functionality;

public class TextPromt
{
    public void startPrompt()
    {

        string x = "Peloponnese";
        string g = "Gods";
        
        Console.WriteLine("--- Welcome, traveller ---\n" +
                          "I am Sokrates. You have arrived in the Greek heartland. Numerous City-states fight for control\n" +
                          "over the " + x.Pastel(Color.Crimson) + ".\n" +
                          "Be careful when you travel around; the ongoing war has increased the danger " +
                          "when travelling on the roads.\n" +
                          "Some are even saying the " + g.Pastel(Color.Crimson) + " have come down to strike anyone who crosses their path.\n" +
                          "What is your name, traveller?\n");
    }


    public void playerWelcomeMessage(Player p)
    {
        
        Console.WriteLine("\nAhh, I see. Well, welcome " + p.playerName.Pastel(Color.GreenYellow) + ".\n" +
                          "Be careful around here, I wouldn't want you to end up like one of those...\n" +
                          "<Sokrates points at some crucified corpses>\n" +
                          "Good luck to you, " + p.playerName.Pastel(Color.GreenYellow) + ". May the gods be with you.\n" +
                          "\nBefore I go, here are the controls: type 'm' to move, 'i' to see your inventory, 'p'" +
                          "for player stats and 'q' to exit.");
        
    }

    public void EnemyHasAppeared(IEnemy enemy)
    {
        CheckRarity cr = new CheckRarity();
        
        Console.WriteLine($"\n {cr.HandleEnemyRarity(enemy)} has appeared and has challenged you to a fight. Do you accept it?(yes = y, no = n)");
    }


}