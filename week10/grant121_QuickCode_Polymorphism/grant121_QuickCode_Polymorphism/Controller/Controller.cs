using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grant121_QuickCode_Polymorphism
{
    class Controller
    {
        #region constructors
        public Controller()
        {
            List<Animal> animals = new List<Animal>();

            animals.Add(BuildLandMamal("Cat", "Orange", 4));
            animals.Add(BuildBird("Hawk",true));
            animals.Add(BuildBird("Dove",true));
            animals.Add(BuildFish("Bignose shark", "Pacific"));
            animals.Add(BuildBird("Penguin",false));
            animals.Add(BuildFish("Indonesian ocellated flounder", "Indian"));
            animals.Add(BuildFish("Black sea bass", "Atlantic"));
            animals.Add(BuildLandMamal("Horse", "White", 4));
            animals.Add(BuildLandMamal("Monkey", "Brown", 2));

            PrintAnimals(animals);


        }
        #endregion


        #region methods
        private Fish BuildFish(string name, string sea)
        {
            return new Fish()
            {
                Name = name,
                PrimarySea = sea
            };
        }

        private Bird BuildBird(string name, bool fly)
        {
            return new Bird()
            {
                Name = name,
                CanFly = fly
            };
        }

        private LandMamal BuildLandMamal(string name, string color, int legs)
        {
            return new LandMamal()
            {
                Name = name,
                Color = color,
                NumOfLegs = legs
            };
        }

        private void PrintAnimals(List<Animal> animals)
        {
            List<Fish> f = new List<Fish>();
            List<Bird> b = new List<Bird>();
            List<LandMamal> m = new List<LandMamal>();

            foreach (var a in animals)
            {
                if (a is Fish)
                {
                    f.Add(a as Fish);
                }
                else if (a is Bird)
                {
                    b.Add(a as Bird);
                }
                else if (a is LandMamal)
                {
                    m.Add(a as LandMamal);
                }
            }

            Console.WriteLine("\n~ Fish ~");
            foreach (Fish fish in f)
            {
                Console.WriteLine("Name: " + fish.Name);
                Console.WriteLine("Location: " + fish.PrimarySea);
                Console.WriteLine();
            }

            Console.WriteLine("~ Birds ~");
            foreach (var bird in b)
            {
                Console.WriteLine("Name: " + bird.Name);
                Console.WriteLine("Flying: " + bird.CanFly);
                Console.WriteLine();
            }

            Console.WriteLine("\n~ Land Mamals ~");
            foreach (var mamal in m)
            {
                Console.WriteLine("Name: " + mamal.Name);
                Console.WriteLine("Color: " + mamal.Color);
                Console.WriteLine("Legs: " + mamal.NumOfLegs);
                Console.WriteLine();
            }
        }

        #endregion
    }
}
