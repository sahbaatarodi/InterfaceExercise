using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE- Create 2 Interfaces called IVehicle & ICompany

            //DONE-Create 3 classes called Car , Truck , & SUV

            //DONE-In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //DONE-In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //DONE-In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            var car = new Car();
            car.Make = "Ford";
            car.IsDrivable = true;
            car.Model = "Mustang";
            car.HasChangedGears = true;
            car.EngineSize = 4.6;
            car.CompanyName = "Ford";
            Console.WriteLine($"Make : {car.Make}, Model : {car.Model}, Company : {car.CompanyName}," +
                $" Engine Size : {car.EngineSize},");
            Console.WriteLine($"Is the car drivable? Has it changed gears ?");
            Console.WriteLine($"{car.IsDrivable}, AND {car.HasChangedGears}");

            var truck = new Truck();
            truck.Make = "Ford";
            truck.Model = "F150";
            truck.CompanyName = "Ford";
            truck.EngineSize = 6;
            truck.SeatCount = 4;
            truck.HasFourWheelDrive = true;
            Console.WriteLine($"Make : {truck.Make}, Model : {truck.Model}, Company : {truck.CompanyName}," +
                $" Engine Size : {truck.EngineSize}, Seat Count: {truck.SeatCount}");
            Console.WriteLine($"Does this truck has 4 wheel?");
            Console.WriteLine($"{truck.HasFourWheelDrive}");


            var suv = new SUV();
            suv.Make = "Ford";
            suv.Model = "Edge";
            suv.CompanyName = "Ford";
            suv.EngineSize = 5;
            suv.CanPark = true;
            suv.MotorSpeed = 130;
            Console.WriteLine($"Make : {suv.Make}, Model : {suv.Model}, Company : {suv.CompanyName}," +
                $" Engine Size : {suv.EngineSize}, Motor Speed: {suv.MotorSpeed}");
            Console.WriteLine($"Can this vehicle park?");
            Console.WriteLine($"{suv.CanPark}");


        }
    }
}
