namespace RPG_TextGame.PlayerInformation;

public class Player
{

    public int playerHealth = 100;
    public List<InheritanceModel.Tool> inv = new List<InheritanceModel.Tool>();
    public String playerName;
    
    

    public Player(String pName)
    {
        this.playerName = pName;
    }
    
}