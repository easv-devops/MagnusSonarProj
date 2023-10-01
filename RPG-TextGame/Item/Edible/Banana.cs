using RPG_TextGame.Interface;

namespace RPG_TextGame.Tool.Edible;

public class Banana : ITool
{
    public String Name = "Banana";
    
    
    public void Act()
    {
    }

    public string GetName()
    {
        return Name;
    }
}