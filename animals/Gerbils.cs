using System;

namespace creature_collection_interfaces
{
    public class Gerbils : IWalking, ILand
    {
        public string livesOnLand { get; set; }

        public void Run()
        {
            Console.WriteLine();
        }

        public void Walk()
        {
            Console.WriteLine();
        }
    }
}