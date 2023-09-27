using System.Drawing;
using System.Net.NetworkInformation;
using Pastel;

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


    public void playerWelcomeMessage(string x)
    {
        
        Console.WriteLine("\nAhh, I see. Well, welcome " + x.Pastel(Color.GreenYellow) + ".\n" +
                          "Be careful around here, I wouldn't want you to end up like one of those...\n" +
                          "<Sokrates points at some crucified corpses>\n" +
                          "Good luck to you, " + x.Pastel(Color.GreenYellow) + ". May the gods be with you.");
        
        
        
    }


}