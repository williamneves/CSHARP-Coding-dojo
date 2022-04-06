using System;
using System.Collections.Generic;

namespace Iron_ninja
{
    public class Buffet
    {
        public List<IConsumable> Menu;


        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Chicken", 350, false, false),
                new Food("Beef", 600, false, false),
                new Food("Pork", 450, false, false),
                new Food("Vegetable", 50, false, false),
                new Food("Rice", 150, false, false),
                new Food("Pasta", 650, false, false),
                new Food("Soup", 180, true, false),
                new Food("Cake", 700, false, true),
                new Food("Pie", 550, false, true),
                new Drink("Coffee", 150, false, false),
                new Drink("Tea", 50, false, false),
                new Drink("Orange Juice", 200, false, false),
                new Drink("Water", 0, false, false)
            };
        }
        public IConsumable Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(0, Menu.Count)];
        }
    }
}