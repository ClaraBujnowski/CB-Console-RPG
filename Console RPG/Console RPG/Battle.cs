using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Battle
    {
        public bool isResolved;
        public List<Enemy> enemies;
        public List<Player> players;

        public Battle(List<Enemy> enemies)
        {
            this.isResolved = false;
            this.enemies = enemies;
        }

        public void Resolve(List<Player> players)
        {
            Console.WriteLine(players[0].name);
            while (true)
            {
                foreach (var item in players)
                {
                    if (item.currentHP > 0)
                    {
                        Console.WriteLine("It's " + item.name + " 's turn.");
                        item.DoTurn(players, enemies);
                    }
                }

                foreach (var item in enemies)
                {
                    if (item.currentHP > 0)
                    { 
                    Console.WriteLine("It's " + item.name + " 's turn.");
                    item.DoTurn(players, enemies);
                    }
                }

                if (players.TrueForAll(player => player.currentHP <= 0))
                {
                    Console.WriteLine("Oopsie, you lost!!!");
                    break;
                }
                if (enemies.TrueForAll(enemy => enemy.currentHP <= 0))
                {
                    Console.WriteLine("Yippee, you won!!!");
                    break;
                }
            }
        }

    }
}
