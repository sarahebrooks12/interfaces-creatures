using System;

namespace creature_collection_interfaces
{
    public class Earthworms : ISlither, ILand
    {
        public string livesOnLand { get; set; }

        public void Slither()
        {
            Console.WriteLine();
        }
    }
}