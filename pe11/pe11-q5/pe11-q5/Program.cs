using System;
using pe11_vehicles;

namespace Traffic
{
    /* Author: Nihal Karim
     * Name: Program
     * Purpose:
     * Restrictions:
     */
    static class Program
    {
        static void Main(string[] args)
        {
            Compact compact = new Compact();
            SUV suv = new SUV();

            AddPassenger(compact);
            AddPassenger(suv);
        }

        public static void AddPassenger(IPassengerCarrier vehicle)
        {
            vehicle.LoadPassenger();
            Console.WriteLine(vehicle.ToString());
        }
    }

    /* Create a console application project, Traffic, which references Vehicles.dll (created in Q5 above).
     * 
     * Include a function called AddPassenger() that accepts any object with the IPassengerCarrier interface.
     * 
     * Within the AddPassenger() function, call the LoadPassenger() method using a reference to the interface.
     * Also add a line to call the ToString() method inherited from System.Object  
     *      (ie. if vehicleObject is passed to the function, call Console.WriteLine(vehicleObject.ToString()).
     * Also try passing an object that did not inherit the IPassengerCarrier interface and see what happens.
     *
     */

    
}
