using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            Car car1 = new Car()
            {
                Make = "Tesla",
                Model = "Model S: Plaid",
                Year = 2022,
                EngineNoise = "No",
                HonkNoise = "Beeep",
                IsDrivable = true,
            };
            Console.WriteLine($"{car1.Make},{car1.Model} {car1.Year}  {car1.IsDrivable}");
            car1.MakeEngineNoise();
            car1.MakeHonkNoise();

            var carLot = new List<Car>();
            carLot.Add(car1);
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car car2 = new Car()
            {
                Year = 1996,
                Make = "Toyota",
                Model = "Corolla",
                IsDrivable = true,
            };
            Console.WriteLine($" This {car2.Year} {car2.Make} {car2.Model} will drive but isn't the most reliable");
            carLot.Add(car2);
            Car car3 = new Car() 
            {
                Year = 2009,
                Make = "Nissan",
                Model = "Maxima",
                IsDrivable=true,
            
            };
            Console.WriteLine($" This {car3.Year} {car3.Make} {car3.Model} is driveable and reliable for a low price");
            carLot.Add(car3);
            //*************BONUS*************//
            Car car4 = new Car() { Year = 1932, Make = "Ford", Model = "Model A" };
            carLot.Add(car4);
            Car car5 = new Car() 
            { 
                Year = 2023,
                Make = "Toyota",
                Model = "Tundra",
            };
            carLot.Add(car5);



            Car car6 = new Car();
            car6.Year = 2004;
            car6.Make = "Audi";
            car6.Model = "a4";
            carLot.Add(car6);
            Carlot.numberOfCars++;
            Console.WriteLine(Carlot.numberOfCars);

            Car car7 = new Car(1967, "Chevrolet", "Chevelle");
            carLot.Add(car7);
            Carlot.numberOfCars++;
            Console.WriteLine(Carlot.numberOfCars);

           Car car8 = new Car(2022, "Toyota", "Supra");
            Carlot.numberOfCars++;

            Console.WriteLine(Carlot.numberOfCars);

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (var car in carLot)
            {
                Console.WriteLine($"{car.Year}\n{car.Make}\n{car.Model}");
                Console.WriteLine();
            }
        }
    }
}
