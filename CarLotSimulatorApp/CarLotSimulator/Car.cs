using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car()
        {
            Year = Year;
            Make = Make;
            Model = Model;

        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string HonkNoise { get; set; }
        public string EngineNoise { get; set; }
        public bool IsDrivable { get; set; }


        public void MakeEngineNoise()
        {
            Console.WriteLine($"This car has a load engine roar {EngineNoise}");
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine($" the car will honk {HonkNoise}");
        }

    }

}
