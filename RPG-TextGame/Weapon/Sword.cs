using RPG_TextGame.Interface;

namespace RPG_TextGame.Tool.Weapon;

public class Sword : IWeapon
{
    public String Name = "Sword";

    public int AttackDamage = 25;

    public void Act()
    {
        
    }

    public int GetDamage()
    {
        return AttackDamage;
    }
}