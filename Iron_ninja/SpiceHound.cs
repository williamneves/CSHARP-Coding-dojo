using System;
using System.Collections.Generic;

namespace Iron_ninja
{
    class SpiceHound : Ninja
    {
        public SpiceHound()
        {
            calorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }

        public override bool IsFull
        {
            get
            {
                if (calorieIntake > 1200)                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override void Consume(IConsumable item)
        {
            if (IsFull == false)
            {
                calorieIntake += item.Calories;
                ConsumptionHistory.Add(item);
                Console.WriteLine($"{item.GetInfo()}");
            }
            else
            {
                Console.WriteLine("SpiceHound is full!");
            }
        }
    }
}