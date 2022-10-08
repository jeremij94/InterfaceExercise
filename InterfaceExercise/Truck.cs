using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany 
    {
        public Truck()
        {
        }

        public string TowingCapacity { get; set; }
        public string DriveTrain { get; set; }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string PaintColor { get; set; }

        public string Logo { get; set; }
        public string Warranty { get; set; }
    }

}

