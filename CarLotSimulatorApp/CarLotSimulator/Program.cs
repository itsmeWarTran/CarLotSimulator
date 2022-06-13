using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            Car Honda = new Car();
            Honda.Year = 2017;
            Honda.Make = "Honda";
            Honda.Model = "Civic";
            Honda.EngineNoise = "Vroom";
            Honda.HonkNoise = "Honk";
            Honda.IsDriveable = true;

            carLot.ParkingLot.Add(Honda);


            Car Tesla = new Car() { Year = 2020, Make = "Tesla", Model = "Truck",
                EngineNoise = "Grrrr",HonkNoise = "Honk",IsDriveable = true};

            carLot.ParkingLot.Add(Tesla);


            var Mercades = new Car(2019, "Mercades", "Benz", "Vroom", "Beep", true);

            carLot.ParkingLot.Add(Mercades);


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach(var c in carLot.ParkingLot)
            {
                Console.WriteLine($"{c.Year}, {c.Make}, {c.Model}");
                c.MakeEngineNoise();
                c.MakeHonkNoise();
                Console.WriteLine("");
            }
        }
    }
}
