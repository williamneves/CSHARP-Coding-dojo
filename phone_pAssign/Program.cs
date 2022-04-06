using System;

namespace phone_pAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            var s22 = new Galaxy("s22", 100, "Verizon", "RingTone");
            var n22 = new Nokia("brick22", 500, "T-mobile", "LoveTone");

            s22.DisplayInfo();
            n22.DisplayInfo();
            Console.WriteLine($"Texting {s22.Ring()}");
            Console.WriteLine($"Texting {n22.Ring()}");
            
        }
    }
}
