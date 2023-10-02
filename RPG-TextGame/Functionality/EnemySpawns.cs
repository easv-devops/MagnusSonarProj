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
            if (num >= 0 && num <= 25)
                Console.WriteLine("No enemies found...");
            if (num > 25 && num <= 60)
            {
                Barbarian bb1 = new Barbarian();
                tp.EnemyHasAppeared(bb1);
                ch.Fight(bb1, p);
            }
            
            if (num > 60 && num <= 80)
            {
                ThracianAxeWarrior tx = new ThracianAxeWarrior();
                tp.EnemyHasAppeared(tx);
                ch.Fight(tx, p);
            }
            if (num > 80 && num <= 95)
            {
                Berserker bs = new Berserker();
                tp.EnemyHasAppeared(bs);
                ch.Fight(bs, p);
            }
            if (num > 95 && num <= 100)
            {
                Zeus z = new Zeus();
                tp.EnemyHasAppeared(z);
                ch.Fight(z, p);
            }
        }
        
        if (p.wl == WorldLocation.CAVE)
        {
            if (num >= 0 && num <= 25)
                Console.WriteLine("No enemies found...");
            if (num > 25 && num <= 60)
            {
                Peasant p1 = new Peasant();
                tp.EnemyHasAppeared(p1);
                ch.Fight(p1, p);
            }
            
            if (num > 60 && num <= 80)
            {
                FootSoldier fs = new FootSoldier();
                tp.EnemyHasAppeared(fs);
                ch.Fight(fs, p);
            }
            if (num > 80 && num <= 95)
            {
                ThessalianHoplite th = new ThessalianHoplite();
                tp.EnemyHasAppeared(th);
                ch.Fight(th, p);
            }
            if (num > 95 && num <= 100)
            {
                Ares ar = new Ares();
                tp.EnemyHasAppeared(ar);
                ch.Fight(ar, p);
            }
        }
    }
}