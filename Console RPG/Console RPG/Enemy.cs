using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_RPG
{
    class Enemy : Entity
    {
        public int coinsDroppedOnDefeat;
        public int experienceOnDefeat;

        public Enemy(string name, string description, int hp, int mana, Stats stats, int coinsDroppedOnDefeat, int experienceOnDefeat) : base(name, hp, mana, stats)
        {
            this.coinsDroppedOnDefeat = coinsDroppedOnDefeat;
            this.experienceOnDefeat = experienceOnDefeat;
        }
        public override Entity ChooseTarget(List<Entity> targets)
        {
            Random random = new Random();
            return targets[random.Next(targets.Count)];
        }
        public override void Attack(Entity target)
        {
            Console.WriteLine(this.name + "attacked" + target.name + "!");
        }

        public void UseItem(Item item, Entity target)
        {
            item.Use(this, target);
        }

        public override void DoTurn(List<Player> players, List<Enemy> enemies)
        {
            Entity target = ChooseTarget(enemies.Cast<Entity>().ToList());
            Attack(target);
        }
    }
}
