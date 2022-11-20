using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public interface IPassengerCarrier
    {
        void LoadPassenger();
    }

    public interface IHeavyLoadCarrier
    {

    }



    public abstract class Vehicle
    {
        public virtual void LoadPassenger() { }
    }



    public abstract class Car : Vehicle
    {

    }

    public abstract class Train : Vehicle
    {

    }



    public class Compact : Car, IPassengerCarrier
    {
        public void LoadPassenger() { }
    }

    public class SUV : Car, IPassengerCarrier
    {
        public void LoadPassenger() { }
    }

    public class Pickup : Car, IPassengerCarrier, IHeavyLoadCarrier
    {
        public void LoadPassenger() { }
    }



    public class PassengerTrain : Train, IPassengerCarrier, IHeavyLoadCarrier
    {
        public void LoadPassenger() { }
    }

    public class FreightTrain : Train, IHeavyLoadCarrier
    {

    }

    public class _424DoubleBogey : Train, IHeavyLoadCarrier
    {

    }
}