using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        public static void PrintNumbers(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintOdds(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void PrintSum(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += i;
                Console.WriteLine($"New number: {i} Sum: {sum}");
            }
        }

        public static void LoopArray(int[] nums)
        {
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }

        public static int FindMax(int[] nums)
        {
            int max = nums[0];
            foreach (int num in nums)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);
            return max;
        }

        public static void GetAverage(int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            Console.WriteLine(sum / nums.Length);
        }
        public static int[] OddArray()
        {
            List<int> oddNums = new List<int>();
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    oddNums.Add(i);
                }
            }
            return oddNums.ToArray();
        }

        public static int GreaterThanY(int[] nums, int y)
        {
            int count = 0;
            foreach (int num in nums)
            {
                if (num > y)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            return count;
        }
        public static void SquareArrayValues(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }
            Console.WriteLine(string.Join(",", nums));
        }
        public static void EliminateNegatives(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    nums[i] = 0;
                }
            }
            Console.WriteLine(string.Join(",", nums));
        }
        public static void MinMaxAveratge(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            int sum = 0;
            foreach (int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
                sum += num;
            }
            Console.WriteLine($"min: {min} max: {max} average: {sum / numbers.Length}");
        }
        public static void ShiftValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Length - 1] = 0;
            Console.WriteLine(string.Join(",", numbers));
        }
        public static object[] NumToString(int[] numbers)
        {
            List<object> nums = new List<object>();
            foreach (int num in numbers)
            {
                if (num < 0)
                {
                    nums.Add("Dojo");
                }
                else
                {
                    nums.Add(num);
                }
            }
            return nums.ToArray();
        }

        static void Main(string[] args)
        {
            PrintNumbers(255);
            PrintOdds(255);
            PrintSum(255);
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            LoopArray(nums);
            int max = FindMax(nums);
            Console.WriteLine(max);
            GetAverage(nums);
            Console.WriteLine(OddArray());
            Console.WriteLine(GreaterThanY(nums, 6));
            SquareArrayValues(nums);
            int[] nums2 = { -1, 2, 3, -4, -5 };
            EliminateNegatives(nums2);
            MinMaxAveratge(nums);
            ShiftValues(nums);
            int[] nums3 = { -1, 2, 3, -4, -5 };
            Console.WriteLine(string.Join(",", NumToString(nums3)));
        }
    }
}
