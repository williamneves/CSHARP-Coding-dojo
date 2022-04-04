using System;

namespace Fundamentals_I
{
    class Program
    {
        static void Main(string[] args)
        {

            string hello = "Assigment Fundamentals I";

            Console.WriteLine(hello);

            Console.WriteLine("All from 1 to 255");
            for(int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Buzzfizz");
            for(int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Now with with while loop");
            int j = 1;
            
            while(j < 256){

                Console.WriteLine(j);
                j++;
            }

            int t = 1;

            while(t < 101){
                if(t % 3 == 0 && t % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(t % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(t % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(t);
                }
                t++;
            }
        }
    }
}
