using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany 
    {
        public SUV()
        {
        }

        public int NumberOfSeats { get; set; }
        public string CargoSpace { get; set; }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string PaintColor { get; set; }

        public string Logo { get; set; }
        public string Warranty { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("Vehicle Info:");
            Console.WriteLine(Year);
            Console.WriteLine(Make);
            Console.WriteLine(Model);
            Console.WriteLine("Additional Info:");
            Console.WriteLine($"Color: {PaintColor}");
            Console.WriteLine("Number of seats: { NumberOfSeats}");
            Console.WriteLine(Logo);
            Console.WriteLine(Warranty);
            Console.WriteLine(CargoSpace);
            Console.WriteLine();
        }
    }
}

