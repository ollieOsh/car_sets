using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Tesla");
            Showroom.Add("Murcielago");
            Showroom.Add("Wraith");
            Showroom.Add("Phantom");

            Console.WriteLine(Showroom.Count);

            Showroom.Add("Tesla");

            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Ford Focus");
            UsedLot.Add("Toyota Camry");

            Showroom.UnionWith(UsedLot);

            Showroom.Remove("Ford Focus");
            foreach(string car in Showroom){
                Console.WriteLine(car);
            }

            HashSet<string> Junkyard = new HashSet<string>() {
                "Tesla", "Toyota Camry", "Hummer", "Beamer"
            };

            Showroom.IntersectWith(Junkyard);
            Showroom.UnionWith(Junkyard);
            Showroom.Remove("Tesla");
            Showroom.Remove("Toyota Camry");

            foreach(string car in Showroom){
                Console.WriteLine(car + " x");
            }
        }
    }
}
