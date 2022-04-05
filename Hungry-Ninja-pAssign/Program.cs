using System;

namespace Hungry_Ninja_pAssign
{
    class Program
    {
        static void Main(string[] args)
        {

            var buffet = new Buffet();
            var ninka = new Ninja();


            while (!ninka.IsFull)
            {
                ninka.Eat(buffet.Serve());
            }

        }
    }
}