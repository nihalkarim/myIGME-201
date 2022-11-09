using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    /* Author: Nihal Karim
     * Namespace: Phone
     * Purpose: questions 4-7 on unit exam 2
     * Restrictions: none
     */
    static class Program
    {
        static void Main(string[] args)
        {
            //Q6 - create obj's for Tardis & PhoneBooth. Create a method UsePhone() to call MakeCall() & HangUp().
            Tardis myTardis = new Tardis();
            PhoneBooth myPhoneBooth = new PhoneBooth();

            UsePhone(myTardis);
            UsePhone(myPhoneBooth);
        }

        static void UsePhone(object obj)
        {
            PhoneInterface interFace = (PhoneInterface)obj;

            //use the interface to call MakeCall() and HangUp()
            interFace.MakeCall();
            interFace.HangUp();


            //Q7 - call OpenDoor() if it's a PhoneBooth object and TimeTravel() if it's a Tardis object.
            if (obj is PhoneBooth)
            {
                PhoneBooth booth = (PhoneBooth)obj;
                booth.OpenDoor();
            }
            else if(obj is Tardis)
            {
                Tardis tardis = (Tardis)obj;
                tardis.TimeTravel();
            }
        }
    }

    public abstract class Phone
    {
        private string phoneNumber;
        public string address;

        public string PhoneNumber;

        public abstract void Connect();
        public abstract void Disconnect();
    }

    public interface PhoneInterface
    {
        public void Answer();
        public void MakeCall();
        public void HangUp();
    }

    public class RotaryPhone : Phone, PhoneInterface
    {
        public void Answer() { }

        public void MakeCall()
        {
            Console.WriteLine("Hello?");
        }

        public void HangUp()
        {
            Console.WriteLine("It was great talking to you!");
        }

        public override void Connect() { }
        public override void Disconnect() { }
    }

    public class PushButtonPhone : Phone, PhoneInterface
    {
        public void Answer() { }

        public void MakeCall() {
            Console.WriteLine("Hello?");
        }

        public void HangUp() {
            Console.WriteLine("It was great talking to you!");
        }

        public override void Connect() { }
        public override void Disconnect() { }
    }

    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public byte WhichDrWho
        {
            get { return this.whichDrWho; }
        }

        public string FemaleSideKick
        {
            get { return this.femaleSideKick; }
        }

        public void TimeTravel() {
            Console.WriteLine("Time travelling into the future!");
        }


        //boolean operator overloading
        public static bool operator < (Tardis a, Tardis b)
        {
            if (a.whichDrWho == 10 && b.whichDrWho != 10) return false;
            if (b.whichDrWho == 10 && a.whichDrWho != 10) return true;

            return a.whichDrWho < b.whichDrWho;
        }

        public static bool operator > (Tardis a, Tardis b)
        {
            if (a.whichDrWho == 10 && b.whichDrWho != 10) return true;
            if (b.whichDrWho == 10 && a.whichDrWho != 10) return false;

            return a.whichDrWho > b.whichDrWho;
        }

        public static bool operator <=(Tardis a, Tardis b)
        {
            if (a.whichDrWho == 10 && b.whichDrWho != 10) return false;
            if (b.whichDrWho == 10) return true;

            return a.whichDrWho <= b.whichDrWho;
        }

        public static bool operator >=(Tardis a, Tardis b)
        {
            if (a.whichDrWho == 10) return true;
            if (b.whichDrWho == 10 && a.whichDrWho != 10) return false;

            return a.whichDrWho >= b.whichDrWho;
        }

        public static bool operator ==(Tardis a, Tardis b)
        {
            return a.whichDrWho == b.whichDrWho;
        }

        public static bool operator !=(Tardis a, Tardis b)
        {
            return a.whichDrWho != b.whichDrWho;
        }
    }

    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;

        public void OpenDoor() {
            Console.WriteLine("The door has been opened!");
        }

        public void CloseDoor() { }
    }
}