using System;
using System.Collections.Generic;

namespace collections_practice
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Create an array to hold integer values 0 through 9
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            //  Create an array of the names "Tim", "Martin", "Nikki", & "Sara"

            string[] names = new string[4] { "Tim", "Martin", "Nikki", "Sara" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //  Create an array of length 10 that alternates between true and false values, starting with true

            bool[] boolean = new bool[10];

            for (int i = 0; i < boolean.Length; i++)
            {
                if (i % 2 == 0)
                {
                    boolean[i] = true;
                }
                else
                {
                    boolean[i] = false;
                }
            }

            foreach (bool value in boolean)
            {
                Console.WriteLine(value);
            }
            
            //  Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Strawberry");
            flavors.Add("Mint");
            flavors.Add("Coffee");
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);

            // Create a dictinoary that will store both string keys as well as string values
            Dictionary<string, string> iceCream = new Dictionary<string, string>();

            Random rand = new Random();

            foreach (string name in names)
            {   
                string temp_flavor = flavors[rand.Next(0,flavors.Count)];
                iceCream.Add(name, temp_flavor);

            }

            foreach (KeyValuePair<string, string> entry in iceCream)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }

            
        }
    }
}
