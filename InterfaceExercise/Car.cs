using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public void CoupeOrSedan(int numberOfDoors)
        {
            if (numberOfDoors == 2)
            {
                Console.WriteLine("Coupe");
            }
            else
            {
                Console.WriteLine("Sedan");
            }
        }

        public bool Convertible { get; set; }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string PaintColor { get; set; }


        public string Logo { get; set; }
        public string Warranty { get; set; }

        public static void PrintInfo()
        {
           
        }
    }

}


