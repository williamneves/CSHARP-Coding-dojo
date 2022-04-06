using System;

namespace Wizard_Ninja_Samurai_cAssign
{
    class Program
    {
static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var john = new Human("John");
            var sakamoto = new Ninja("Sakamoto");
            var merlin = new Wizard("Merlin");
            var nikko = new Samurai("Nikko");
            System.Console.WriteLine(john.Health);
            System.Console.WriteLine(sakamoto.Health);

            sakamoto.Attack(john);
            sakamoto.Attack(merlin);
            john.Attack(sakamoto);
            john.Attack(sakamoto);
            sakamoto.Steal(nikko);
            System.Console.WriteLine(john.Health);
            System.Console.WriteLine(sakamoto.Health);
            System.Console.WriteLine(merlin.Health);
            System.Console.WriteLine(nikko.Health);

        }
    }
}
