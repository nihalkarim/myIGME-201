using System;

namespace StructToClass
{
    struct FriendStruct
    {
        public string name;
        public string greeting;
        public DateTime birthdate;
        public string address;
    }

    class Program
    {

        static void Main(string[] args)
        {
            //FriendStruct friend; => struct version
            //FriendStruct enemy; => struct version

            FriendClass friend = new FriendClass();
            FriendClass enemy;

            // create my friend Charlie Sheen
            friend.name = "Charlie Sheen";
            friend.greeting = "Dear Charlie";
            friend.birthdate = DateTime.Parse("1967-12-25");
            friend.address = "123 Any Street, NY NY 12202";

            // now he has become my enemy
            enemy = (FriendClass)friend.GetCopy(); // => for class version, create a shallow copy w the MemberwiseClone() method so that the objects are not the same

            // set the enemy greeting and address without changing the friend variable
            enemy.greeting = "Sorry Charlie";
            enemy.address = "Return to sender. Address unknown.";

            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");
        }
    }

    public class FriendClass
    {
        public string name;
        public string greeting;
        public DateTime birthdate;
        public string address;

        public object GetCopy()
        {
            return MemberwiseClone();
        }
    }
}
