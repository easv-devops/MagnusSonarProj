using RPG_TextGame.Functionality;
using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Interface;

public interface IEnemy
{
    RarityLevel getRarity();

    string getName();

    int getDamage();

    int getHealth();

}