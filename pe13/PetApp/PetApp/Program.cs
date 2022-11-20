using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PetApp
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
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            int petEl;

            Pets pets = new Pets();

            Random rand = new Random();

            for (int i = 0; i < 50; i++)
            {

                if (rand.Next(1, 11) == 1)
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("\nYou bought a dog!");

                        Console.Write("What's the license?   ");
                        string license = Console.ReadLine();

                        Console.Write("What are you naming it?   ");
                        string dogName = Console.ReadLine();

                        Console.Write("How old is the dog?   ");
                        int dogAge = Convert.ToInt32(Console.ReadLine());

                        dog = new Dog(license, dogName, dogAge);
                        thisPet = dog;
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("\nYou bought a cat!");

                        Console.Write("What are you naming it?   ");
                        string catName = Console.ReadLine();

                        Console.Write("How old is the cat?   ");
                        int catAge = Convert.ToInt32(Console.ReadLine());

                        cat = new Cat();
                        thisPet = cat;
                        Console.WriteLine("");
                    }

                    pets.Add(thisPet);
                }
                else
                {
                    petEl = rand.Next(0, pets.Count);

                    thisPet = pets[petEl];

                    if (thisPet == null)
                    {
                        continue;
                    }

                    if (thisPet.GetType() == typeof(Dog))
                    {
                        thisPet.Name = "Puppy";
                        iDog = (IDog)thisPet;

                        int randomMethod = rand.Next(0, 5);

                        if(randomMethod == 0)
                        {
                            iDog.Eat();
                        }
                        else if (randomMethod == 1)
                        {
                            iDog.Play();
                        }
                        else if (randomMethod == 2)
                        {
                            iDog.Bark();
                        }
                        else if (randomMethod == 3)
                        {
                            iDog.NeedWalk();
                        }
                        else if (randomMethod == 4)
                        {
                            iDog.GotoVet();
                        }
                    }
                    else
                    {
                        thisPet.Name = "Kitty";
                        iCat = (ICat)thisPet;

                        int randomMethod = rand.Next(0, 4);

                        if (randomMethod == 0)
                        {
                            iCat.Eat();
                        }
                        else if (randomMethod == 1)
                        {
                            iCat.Play();
                        }
                        else if (randomMethod == 2)
                        {
                            iCat.Purr();
                        }
                        else if (randomMethod == 3)
                        {
                            iCat.Scratch();
                        }
                    }
                }
            }
        }
    }

    public interface ICat
    {
        public void Eat();
        public void Play();
        public void Scratch();
        public void Purr();
    }

    public interface IDog
    {
        public void Eat();
        public void Play();
        public void Bark();
        public void NeedWalk();
        public void GotoVet();
    }

    public abstract class Pet
    {
        private string name;
        public int age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        public Pet() { }

        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


        public abstract void Eat();
        public abstract void Play();
        public abstract void GotoVet();

    }

    //The member methods in Dog and Cat should call Console.WriteLine() with the pet's name and a phrase that suggests the activity. 
    public class Cat : Pet, ICat
    {
        public Cat() { }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is enjoying the cat food.");
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} likes playing with the cat toys.");
        }

        public void Purr()
        {
            Console.WriteLine($"{Name} is purring.");
        }

        public void Scratch()
        {
            Console.WriteLine($"{Name} is scratching the cat pole.");
        }

        public override void GotoVet()
        {
            Console.WriteLine($"{Name} needs to go to the cat vet.");
        }
    }

    public class Dog : Pet, IDog
    {
        public string license;

        public Dog(string szLicense, string szName, int nAge) : base(szName, nAge)
        {
            this.license = szLicense;
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is enjoying the dog food.");
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} likes chasing their tail.");
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} barks a lot.");
        }

        public void NeedWalk()
        {
            Console.WriteLine($"{Name} needs to go on a walk asap.");
        }

        public override void GotoVet()
        {
            Console.WriteLine($"{Name} has a vet appointment next week.");
        }

    }

    public class Pets
    {
        public List<Pet> petList = new List<Pet>();

        public int Count
        {
            get { return petList.Count; }
        }

        public void Add(Pet pet)
        {
            petList.Add(pet);
        }

        public void Remove(Pet pet)
        {
            petList.Remove(pet);
        }

        public void RemoveAt(int petEl)
        {
            petList.RemoveAt(petEl);
        }

        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                // if the index is less than the number of list elements
                if (nPetEl < petList.Count)
                {
                    // update the existing value at that index
                    petList[nPetEl] = value;
                }
                else
                {
                    // add the value to the list
                    petList.Add(value);
                }
            }
        }

    }
}
