using System;
using System.Collections.Generic;

namespace Wizard_Ninja_Samurai_cAssign
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name, 5, 10, 175, 125){}

        public override void Attack(Human target)
        {
            int dmg = -(int) (strength * (strength*(dexterity/100)));
            Console.WriteLine($"Text: {name} attacked {target.name} for {dmg} damage!");
            
            target.changeHealth(dmg);
            
            Random rand = new Random();
            int[] all_chances = new int[5] {1, 2, 3, 4, 5};
            int chance = rand.Next(1, 6);
            if (chance == 1)
            {
                target.changeHealth(-10);
                Console.WriteLine($"Critical hit!!! {name} got more {10} damage in {target.name}!");
                
            }
            
        }
        public void Steal(Human target)
        {
            target.changeHealth(-5);
            this.changeHealth(5);
            this.displayHealth();
        }
    }

}