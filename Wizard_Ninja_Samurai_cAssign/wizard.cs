using System;
using System.Collections.Generic;

namespace Wizard_Ninja_Samurai_cAssign
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name, 2, 25, 3, 50){}

        public override void Attack(Human target)
        {
            int dmg = -(int) (this.intelligence);
            Console.WriteLine($"Text: {name} attacked {target.name} for {dmg} damage!");
            
            target.changeHealth(dmg);
            
            Random rand = new Random();
            int[] all_chances = new int[7] {1, 2, 3, 4, 5, 6, 7};
            int chance = rand.Next(1, all_chances.Length);
            if (chance == 1)
            {
                target.changeHealth(-this.intelligence);
                Console.WriteLine($"Critical hit!!! {name} got more {this.intelligence} damage in {target.name}!");
                
            }

            this.changeHealth(this.intelligence);
            
        }
        public void Heal(Human target)
        {
            target.changeHealth(10*this.intelligence);
        }
    }

}