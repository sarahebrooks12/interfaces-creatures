using System;

namespace creature_collection_interfaces
{
    public class Terrapins : IWalking, ILand, ISwimming
    {
        public Boolean livesOnLand { get; set; }

        public int MaximumDepth => throw new NotImplementedException();

        public void Run()
        {
            Console.WriteLine();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }

        public void Walk()
        {
            Console.WriteLine();
        }
    }
}