using System;

namespace ValuesVsReferences;

class Program
{
    public static void Main(string[] args)
    {
        Canine spot = new("Spot", "pug");
        Canine bob = spot;
        bob.Name = "Spike";
        bob.Breed = "beagle";
        spot.Speak();
        bob.Speak();

        Dog jake = new("Jake", "poodle");
        Dog betty = jake;
        betty.Name = "Betty";
        betty.Breed = "pit bull";
        jake.Speak();
        betty.Speak();
        Console.ReadKey();
    }
}