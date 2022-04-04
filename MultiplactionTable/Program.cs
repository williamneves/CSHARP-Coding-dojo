using System;
using System.Collections.Generic;

namespace MultiplactionTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] table = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    table[i, j] = (i+1) * (j+1);
                }

                Console.WriteLine("[ " + table[i, 0] + ", " + table[i, 1] + ", " + table[i, 2] + ", " + table[i, 3] + ", " + table[i, 4] + ", " + table[i, 5] + ", " + table[i, 6] + ", " + table[i, 7] + ", " + table[i, 8] + ", " + table[i, 9] + " ]");
            }

        }
    }
}
