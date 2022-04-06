using System;
using System.Collections.Generic;

namespace Wizard_Ninja_Samurai_cAssign
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name, 10, 15, 200, 200){}

        public override void Attack(Human target)
        {
            int dmg = -(int) (strength * (strength*(dexterity/100)));
            Console.WriteLine($"Text: {name} attacked {target.name} for {dmg} damage!");
            
            target.changeHealth(dmg);
            
            if (target.Health < 50)
            {
                target.setHealth(0);
            }
            
        }
        public void Meditate()
        {
            this.setHealth(200);
        }
    }

}