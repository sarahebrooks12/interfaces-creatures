using System;

namespace creature_collection_interfaces
{
    public interface ISwimming
    {
        int MaximumDepth { get; }
        void Swim();
    }
}