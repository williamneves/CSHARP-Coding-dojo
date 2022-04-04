using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                int randomNumber = rnd.Next(1, 10);
                Console.WriteLine(randomNumber);
            }
        }


    }
}
