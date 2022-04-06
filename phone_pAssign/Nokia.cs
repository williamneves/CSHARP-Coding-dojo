using System;

namespace phone_pAssign
{
    class Nokia : Phone, IRingable
    {
        public string Name { get; set; }
        
        
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone)
            : base(versionNumber, batteryPercentage, carrier, ringTone)
        {

        }
        private bool isUnlocked;

        // This is just a fun way to make Nokia special
        private static string silentTone = "Zzz zzz zzz";
        public string Ring()
        {
            // ternary expression:
            // if   ( is true)  ? do this  : else, do this
            return (isUnlocked) ? RingTone : silentTone;
        }
        public string Unlock()
        {
            isUnlocked = true;
            return "Unlocked with password";
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("\n**__**--**__**\n");
            Console.WriteLine($"Nokia: {VersionNumber}");
            Console.WriteLine($"Carrier: {Carrier}");
            Console.WriteLine($"Ring Tone: {RingTone}");
            Console.WriteLine("\n**__**--**__**\n");
        }
    }

}