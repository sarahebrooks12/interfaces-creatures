using System;

namespace creature_collection_interfaces
{
    public class Parakeets : IFly, IAir
    {
        public string livesInAir { get; set; }

        public void Fly()
        {
            Console.WriteLine();
        }
    }
}