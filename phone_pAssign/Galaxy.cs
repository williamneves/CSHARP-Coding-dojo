using System;

namespace phone_pAssign
{
    class Galaxy : Phone, IRingable
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone)
        : base(versionNumber, batteryPercentage, carrier, ringTone) 
        { 

        }
        public string Ring()
        {
            return RingTone;
        }
        public string Unlock()
        {
            return "Unlocked with Face ID";
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("\n**__**--**__**\n");
            Console.WriteLine($"Galaxy: {VersionNumber}");
            Console.WriteLine($"Carrier: {Carrier}");
            Console.WriteLine($"Ring Tone: {RingTone}");
            Console.WriteLine("\n**__**--**__**\n");
        }
    }
}