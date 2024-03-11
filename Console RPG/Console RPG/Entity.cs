using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    // Structs are useful for storing simple data
    struct Stats
    {
        public int strength;
        public int defense;
        public int speed;

        // This is composition
        public Stats(int strength, int defense, int speed)
        {
            this.strength = strength;
            this.defense = defense;
            this.speed = speed;
        }
    }
    // Classes are useful for storing complex objects
    abstract class Entity
    {
        public string name;

        public int currentHP, maxHP;
        public int currentMana, maxMana;
        public Stats stats;
        public Entity(string name, int hp, int mana, Stats stats)
        {
            this.name = name;
            this.currentHP = hp;
            this.maxHP = hp;
            this.currentMana = mana;
            this.maxMana = mana;
            this.stats = stats;
        }
        public abstract void DoTurn(List<Player> players, List<Enemy> enemies);
        public abstract Entity ChooseTarget(List<Entity> targets);
        public abstract void Attack(Entity target);
    }
}
