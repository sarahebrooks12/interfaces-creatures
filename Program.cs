using System;

namespace creature_collection_interfaces
{
// Each container will hold animals of similar similar, but different, types.
// -- Animals that dig and live in the ground
// -- Animals that move about on the ground
// -- Animals that swim in water
// -- Animals that fly above the ground
// -- Before you write any classes for the above animals, determine the common properties and behaviors that some of them share and define interfaces first.
// -- Once you believe you have a good set of interfaces, then start creating your specific animal classes and have them implement the appropriate interface.
// -- Then define classes to represent the containers that will hold various animals. Each container class should have a single property - a list to hold animal instances.
// Lastly, in Main() create one (or more if you like) instances of each type of animal and each container. Then add the animals to their corresponding container.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the zoo apparently.");

            Ants antony = new Ants(){
                livesOnLand = true
            };
            BettaFishes betta = new BettaFishes(){
                livesInWater = true
            };
            CopperheadSnakes copper = new CopperheadSnakes(){
                livesOnLand = true
            };
            Earthworms wormy = new Earthworms(){
                livesOnLand = true
            };
            Finches finn = new Finches(){
                livesInAir = true
            };
            Gerbils gerald = new Gerbils(){
                livesOnLand = true
            };
            Mice mickey = new Mice(){
                livesOnLand = true
            };
            Parakeets peepers = new Parakeets(){
                livesInAir = true
            };
            Terrapins backItUpTerry = new Terrapins(){
                livesOnLand = true
            };
            TimberRattleSnakes rattler = new TimberRattleSnakes(){
                livesOnLand = true
            };


            Box boxContainer = new Box();
            SmallBox smallBoxContainer = new SmallBox();
            Cage cageContainer = new Cage();
            Tank tankContainer = new Tank();

            smallBoxContainer.Walkers.Add(antony);
            tankContainer.Swimming.Add(betta);
            boxContainer.Slithers.Add(copper);
            boxContainer.Slithers.Add(wormy);
            cageContainer.Fliers.Add(finn);
            smallBoxContainer.Walkers.Add(gerald);
            smallBoxContainer.Walkers.Add(mickey);
            cageContainer.Fliers.Add(peepers);
            tankContainer.Swimming.Add(backItUpTerry);
            boxContainer.Slithers.Add(rattler);



        }
    }
}
