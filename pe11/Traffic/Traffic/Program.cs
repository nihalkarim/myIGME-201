using System;
using Vehicles;

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
            FreightTrain freightTrain = new FreightTrain();

            AddPassenger(compact);
            //AddPassenger(freightTrain); => creates error
        }

        public static void AddPassenger(IPassengerCarrier vehicle)
        {
            vehicle.LoadPassenger();
            Console.WriteLine(vehicle.ToString());
        }
    }
}
