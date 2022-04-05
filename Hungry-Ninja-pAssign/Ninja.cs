using System;
using System.Collections.Generic;

namespace Hungry_Ninja_pAssign
{
    public class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        public bool IsFull {get{return calorieIntake > 1200;}}

        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        public void Eat(Food item)
        {
            if(!IsFull)
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"{item.Name} has been added to the ninja's food history.");
                Console.WriteLine($"And ninja now has {calorieIntake} calories.");
                
            }
            else
            {
                Console.WriteLine("Ninja is full!");
            }
        }

    }
}
