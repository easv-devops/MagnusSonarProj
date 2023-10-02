using RPG_TextGame.PlayerInformation;

namespace RPG_TextGame.Interface;

public interface ITool
{
    void Act(Player player);

    string GetName();
}