using System;
using System.Collections.Generic;

namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> list = new List<object>();

            list.Add(7);
            list.Add(28);
            list.Add(-1);
            list.Add(true);
            list.Add("chair");

            var sum = 0;

            foreach (var item in list)
            {
                Console.WriteLine(item);
                if (item is int)
                {
                    sum += (int)item;
                }

            }
            Console.WriteLine($"sum: {sum}");
        }
    }
}
