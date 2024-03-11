using System.Collections.Generic;

namespace Console_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy1 = new Enemy("Lost Wisp", "It looks confused", 20, 5, new Stats(15, 5, 10), 10, 5);
            Enemy enemy2 = new Enemy("Red Wisp", "Red hot and blazing", 25, 10, new Stats(20, 10, 12), 12, 8);

            HealthPotionItem potion1 = new HealthPotionItem("Health Potion", "Gives you an energy boost", 12, 10, 15);
            HealthPotionItem potion2 = new HealthPotionItem("Diet Health Potion", "Now with less sugar", 15, 10, 12);
            HealthPotionItem potion3 = new HealthPotionItem("Strong Health Potion", "The good stuff!", 20, 5, 20);

            BowAndArrow bow1 = new BowAndArrow("Training Bow", "Safe for ages 8-11", 10, 1, 5, 15);
            BowAndArrow bow2 = new BowAndArrow("Real Bow", "Does real damage", 20, 1, 15, 10);

            Sword sword1 = new Sword("Wooden Sword", "Made entirely of driftwood", 10, 1, 10);
            Sword sword2 = new Sword("Steel Sword", "Sharp and polished", 20, 1, 15);

            Location location1 = new Location("The Wild Forest", "It looks dark and unwelcoming", new Battle(new List<Enemy>() { enemy1 }));
            Location location2 = new Location("Town", "Small and quaint");
            Location location3 = new Location("Midnight Cave", "It's completely devoid of light");

            location2.north = location1;

            location1.Resolve(new List<Player>() { Player.player1 });
        }
    }
}
