using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //-DONE Create 2 Interfaces called IVehicle & ICompany

            //-DONE Create 3 classes called Car , Truck , & SUV

            //-Done In your IVehicle
            
                /* -Done Create 4 members that Car, Truck, & SUV all have in common.
                 * -Done Example: All vehicles have a number of wheels... for now..
                 */
            

            //- DONEIn ICompany
            
                /*-DONECreate 2 members that are specific to each every company
                 * -DONEregardless of vehicle type.
                 *
                 *
                 *-OK Example: public string Logo { get; set; }
                 */

            //-DONE In each of your car, truck, and suv classes

                /*-DONE Create 2 members that are specific to each class
                 * -OKExample: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * -DONEThen, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //***member vaules have been preset.***
            var car = new Car();

            var truck = new Truck();
            var suv = new Suv();

            //Creatively display and organize their values
            var vehicles = new List<IVehicle>() { car, truck, suv };
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"company: {vehicle.Name}");
                Console.WriteLine($"Logo:{vehicle.Logo}");
                Console.WriteLine($"Year:{vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                
                Console.WriteLine($"seat count: {vehicle.SeatCount}");
                Console.WriteLine($"engine size:{vehicle.EngineSize}");
                Console.WriteLine($"number of wheels: { vehicle.NumberOfWheels}");
                Console.WriteLine($"trunk type: {vehicle.TrunkType}");
                vehicle.Drive();
                vehicle.Reverse();
                vehicle.Park();
                Console.WriteLine("__-__-__-__-__-__-__-__-__-__-__-__-__-__-__-");

            }
            //COPY CODE AND RUN
            
        }
    }
}
