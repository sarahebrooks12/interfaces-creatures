using System;

namespace creature_collection_interfaces
{
    public class BettaFishes : ISwimming, ISea
    {
        public int MaximumDepth {get; set; }

        public string livesInWater { get; set; }

        public void Swim()
        {
            Console.WriteLine();
        }
    }
}