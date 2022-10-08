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
    }
}

