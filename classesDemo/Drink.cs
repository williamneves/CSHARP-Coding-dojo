using System;

namespace classesDemo
{
    public class Drink
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsAlcoholic { get; set; }
        public int Calories { get; set; }
        public string[] Ingredients { get; set; }

        public Drink(string name, string description, double price, bool isAlcoholic, int calories, string[] ingredients)
        {
            Name = name;
            Description = description;
            Price = price;
            IsAlcoholic = isAlcoholic;
            Calories = calories;
            Ingredients = ingredients;
        }
    }
}