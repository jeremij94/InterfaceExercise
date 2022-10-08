using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            SUV newSuv = new SUV()
            {
                Logo = "Jack Russell",
                Year = 2018,
                Make = "Chevrolet",
                Model = "Tahoe",
                PaintColor = "Black",
                NumberOfSeats = 9,
                CargoSpace = "15.3 cubic ft., 94.7 cubic ft. with seat area",
                Warranty = "The Jack Russell 5yr/60,000mi Warranty",
            };

            Car newCar = new Car();
            newCar.Logo = "Harold's Hoopties";
            newCar.Year = 1999;
            newCar.Make = "Buick";
            newCar.Model = "LeSabre";
            newCar.PaintColor = "Bronze";
            newCar.CoupeOrSedan(4);
            newCar.Convertible = false;

            newCar.Warranty = "Wait who are you? What car? No warranty in the contract";

            var newTruck = new Truck()
            {
                Year = 2023,
                Make = "Toyota",
                Model = "Tundra TRD Pro",
                PaintColor = "Cement Gray"
            };

            newTruck.TowingCapacity = "8,300 to 12,000lbs";
            newTruck.DriveTrain = "4WDemand part - time 4 - Wheel Drive with electronically controlled 2 - speed transfer case (high / low range) and Automatic Limited - Slip Differential(Auto LSD)"
            newTruck.Logo = "Local Toyota Dealership";
            newTruck.Warranty = "Whatever Toyota Says.";


    }
                
    }
}
