using System;
using System.Collections.Generic;

namespace ISMPrakt11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Car(new[] { "Tesla, red" }));
            vehicles.Add(new Train(new[] { "Hundai, blue" }));
            vehicles.Add(new Taxi(new[] { "Yellow, Mazda" }));
            vehicles.Add(new Bicycle(new[] { "Purple, little" }));

            Random rnd = new Random();

            int i = 0;

            //Random Initialization 
            foreach (Vehicle v in vehicles) 
            {
                v.Ride("Some City " + i, rnd.Next(1, 100));
            }

            Console.WriteLine("==============Data=============");

            foreach (Vehicle v in vehicles) 
            {
                Console.WriteLine(v.GetData());
                Console.WriteLine("===============================");
            }
        }
    }
}
