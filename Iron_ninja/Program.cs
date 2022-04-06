using System;

namespace Iron_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            var buffet = new Buffet();
            // Ninja ninka = new Ninja();
            SweetTooth sweet = new SweetTooth();
            var spice = new SpiceHound();


            while (!sweet.IsFull)
            {
                sweet.Consume(buffet.Serve());
            }
            while (!spice.IsFull)
            {
                spice.Consume(buffet.Serve());
            }


        }
    }
}
