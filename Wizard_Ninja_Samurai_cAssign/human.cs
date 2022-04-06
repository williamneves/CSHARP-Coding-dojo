using System;
using System.Collections.Generic;

namespace Wizard_Ninja_Samurai_cAssign
{
    public class Human
    {
        public string name;
        public int strength;
        public int intelligence;
        public int dexterity;
        private int health;
        public int Health { get { return health; } }

        public Human(string name)
        {
            this.name = name;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }

        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            this.name = name;
            this.strength = strength;
            this.intelligence = intelligence;
            this.dexterity = dexterity;
            this.health = health;
        }

        public virtual int Attack(Human target)
        {
            target.health -= 5 * strength;
            System.Console.WriteLine($"{name} attacked {target.name} for {5 * strength} damage! Now {target.name} has {target.health} health left.");
            
            return target.health;
        }

        protected virtual void IncreaseHealth(int amount){
            health += amount;
        }
    }
}