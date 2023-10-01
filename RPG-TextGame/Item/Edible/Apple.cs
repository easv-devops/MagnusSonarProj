using RPG_TextGame.Interface;

namespace RPG_TextGame.Tool.Edible;

public class Apple : ITool
{
    public String Name = "Apple";
    
    
    public void Act()
    {
    }

    public string GetName()
    {
        return Name;
    }
}