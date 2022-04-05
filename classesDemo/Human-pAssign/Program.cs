using System;

namespace Human_pAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var hulk = new Human("Hulk");
            var thor = new Human("Thor");

            hulk.Attack(thor);
            thor.Attack(hulk);
            thor.Attack(hulk);
            System.Console.WriteLine(thor.Health);
            System.Console.WriteLine(hulk.Health);

        }
    }
}
