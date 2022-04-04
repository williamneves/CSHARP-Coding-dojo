using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        //Print the max and min from a list of ints
        static void printMinMax(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("min: " + min + " max: " + max);
        }

        // Prints the sum of all the numbers in the array
        static void printSumArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("sum: " + sum);
        }

        // Random Array Generator
        static int[] RandomArray()
        {
            Random rand = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(5, 25);
            }

            printMinMax(numbers);
            printSumArray(numbers);

            return numbers;
        }

        // Coin Flip

        static string TossCoin()
        {
            Random rand = new Random();
            int flip = rand.Next(0, 2);
            if (flip == 0)
            {
                return "Heads";
            }
            else
            {
                return "Tails";
            }
        }
        static double TossMultipleCoins(int num)
        {
            int heads = 0;
            int tails = 0;
            for (int i = 0; i < num; i++)
            {
                string result = TossCoin();
                if (result == "Heads")
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }
            double ratio = (double)heads / (double)tails;
            return ratio;
        }

        // Names
        static List<string> Names()
        {
            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");
            
            List<string> shuffledNames = new List<string>();
            Random rand = new Random();

            while(names.Count > 0)
            {
                int index = rand.Next(0, names.Count);
                if (names[index].Length > 5){
                    shuffledNames.Add(names[index]);
                }
                names.RemoveAt(index);
            }
            return shuffledNames;
        }

        static void Main(string[] args)
        {
            RandomArray();
            Console.WriteLine(TossCoin());
            Console.WriteLine(TossMultipleCoins(50));
            Names();
            List<string> stringnames = Names();

            foreach (string name in stringnames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
