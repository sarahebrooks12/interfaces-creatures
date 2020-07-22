using System;

namespace creature_collection_interfaces
{
    public class Ants : IWalking, ILand
    {
        public Boolean livesOnLand { get; set; }

        public void Run()
        {
            Console.WriteLine("MARCH");
        }

        public void Walk()
        {
            Console.WriteLine("march");

        }
    }
}