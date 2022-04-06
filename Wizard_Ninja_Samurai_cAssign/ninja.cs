using System;

namespace Wizard_Ninja_Samurai_cAssign
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            dexterity = 175;
            intelligence = 10;
            // IncreaseHealth(25);
            strength = 5;
        }
        public override int Attack(Human target)
        {
            // int dmg = (int) (5 * (strength*(dexterity/10)));
            // Console.WriteLine($"Text: {name} attacked {target.name} for {dmg} damage!");
            
            // target.health -= dmg;
            
            // Random rand = new Random();
            // arr[] all_chances = new arr[5] {1, 2, 3, 4, 5};
            // int chance = rand.Next(1, 6);
            // if (chance == 1)
            // {
            //     target.health -= 10;
            //     Console.WriteLine($"Critical hit!!! {name} got more {10} damage in {target.name}!");
                
            // }

            // target.health -= 10;
            
        }
    }

}