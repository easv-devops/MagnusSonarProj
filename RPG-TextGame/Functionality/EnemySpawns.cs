using RPG_TextGame.Enemy;
using RPG_TextGame.Enemy.CommonEnemy;
using RPG_TextGame.PlayerInformation;
using RPG_TextGame.World;

namespace RPG_TextGame.Functionality;

public class EnemySpawns
{

    public void SpawnEnemies(Player p)
    {
        
        TextPromt tp = new TextPromt();
        CombatHandler ch = new CombatHandler();
        
        Random _random = new Random();
        int num = _random.Next(0, 101);
        
        if (p.wl == WorldLocation.ROAD)
        {
            if (num >= 0 && num <= 25)
                Console.WriteLine("No enemies found...");
            if (num > 25 && num <= 60)
            {
                Bandit b1 = new Bandit();
                tp.EnemyHasAppeared(b1);
                ch.Fight(b1, p);
            }
            
            if (num > 60 && num <= 80)
            {
                GreekMercenary gc = new GreekMercenary();
                tp.EnemyHasAppeared(gc);
                ch.Fight(gc, p);
            }
            if (num > 80 && num <= 95)
            {
                SpartanHoplite sh = new SpartanHoplite();
                tp.EnemyHasAppeared(sh);
                ch.Fight(sh, p);
            }
            if (num > 95 && num <= 100)
            {
                Ares ar = new Ares();
                tp.EnemyHasAppeared(ar);
                ch.Fight(ar, p);
            }
        }
        
        if (p.wl == WorldLocation.CITY)
        {
            /// ADD COMBAT IN OTHER REGIONS
        }
        
        if (p.wl == WorldLocation.CAVE)
        {
            /// ADD COMBAT IN OTHER REGIONS
        }
    }
}