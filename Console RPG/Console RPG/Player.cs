using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_RPG
{
    class Player : Entity
    {
        public static List<Item> Inventory = new List<Item>();

        public static Player player1 = new Player("Player 1", 25, 10, new Stats(10, 10, 20), 10);

            public int level;

            public Player(string name, int hp, int mana, Stats stats, int level) : base(name, hp, mana, stats)
            {
                this.level = level;
            }

            public override Entity ChooseTarget(List<Entity> choices)
            {
                for (int i = 0; i < choices.Count; i++)
                 {
                     Console.WriteLine($"{i + 1}: {choices[i].name}");
                 }

            int index = Convert.ToInt32(Console.ReadLine());
            return choices[index - 1];
            }
        public Item ChooseItem(List<Item> choices)
        {
            Console.WriteLine("Type in the number of the item you want to use:");

            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {choices[i].name}");
            }

            int index = Convert.ToInt32(Console.ReadLine());
            return choices[index - 1];
        }

        public override void Attack(Entity target)
        {
            Console.WriteLine(this.name + "attacked" + target.name + "!");
            //target.currentHP -= this.strength;
        }

        public override void Attack(Entity target)
        {
            Console.WriteLine(this.name + "attacked" + target.name + "!");
            //target.currentHP -= this.strength;
        }
        public override void DoTurn(List<Player> players, List<Enemy> enemies)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("ATTACK | ITEM");
            string choice = Console.ReadLine();

            if (choice == "ATTACK")
            {
                Entity target = ChooseTarget(players.Cast<Entity>().ToList());
                Attack(target);
            }
            else if (choice == "ITEM")
            {
                Item item = ChooseItem(Inventory);
                Entity target = ChooseTarget(players.Cast<Entity>().ToList());

                Item.Use(this, target);
            }
        }
    }
}
