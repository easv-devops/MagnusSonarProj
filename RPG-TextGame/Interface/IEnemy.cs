using RPG_TextGame.Functionality;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Interface;

public interface IEnemy
{
    void Fight(Player p);


    RarityLevel getRarity();

    string getName();

    int getDamage();

    int getHealth();

}