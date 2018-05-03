using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickCodeClass
{

    public enum Breed
    {
        british_shorthair,
        siamese,
        persian,
        ragdoll,
        maine_coon,
        bengal
    }

    class Cat
    {
        #region fields
        private string _name;
        private int _age;
        private double _weight;
        private bool _declawed;
        private DateTime _adopt;
        private Breed _type;

        #endregion

        #region properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public bool Declawed
        {
            get { return _declawed; }
            set { _declawed = value; }
        }

        public DateTime Adopt
        {
            get { return _adopt; }
            set { _adopt = value; }
        }

        public Breed Type
        {
            get { return _type; }
            set { _type = value; }
        }

        #endregion

        #region constructors
        public Cat()
        {
            Random rng = new Random();

            //set name
            //
            switch (rng.Next(4))
            {
                case 0:
                    _name = "Mittens";
                    break;
                case 1:
                    _name = "Fluff Bun";
                    break;
                case 2:
                    _name = "Omega Paw";
                    break;
                case 3:
                    _name = "Jerry";
                    break;
            }

            //set age
            //
            switch (rng.Next(4))
            {
                case 0:
                    _age = 3;
                    break;
                case 1:
                    _age = 7;
                    break;
                case 2:
                    _age = 1;
                    break;
                case 3:
                    _age = 12;
                    break;
            }

            //set weight
            //
            switch (rng.Next(4))
            {
                case 0:
                    _weight = 7.9;
                    break;
                case 1:
                    _weight = 9.9;
                    break;
                case 2:
                    _weight = 6.2;
                    break;
                case 3:
                    _weight = 14.5;
                    break;
            }

            //set declawed
            //
            switch (rng.Next(2))
            {
                case 0:
                    _declawed = false;
                    break;
                case 1:
                    _declawed = true;
                    break;
            }

            //set adopt
            //
            _adopt = DateTime.Now;

            //set type
            //
            switch (rng.Next(6))
            {
                case 0:
                    _type = Breed.bengal;
                    break;
                case 1:
                    _type = Breed.british_shorthair;
                    break;
                case 2:
                    _type = Breed.maine_coon;
                    break;
                case 3:
                    _type = Breed.persian;
                    break;
                case 4:
                    _type = Breed.ragdoll;
                    break;
                case 5:
                    _type = Breed.siamese;
                    break;
            }
        }

        #endregion

        #region methods
        public string ReturnInfo()
        {
            string info = $"Name: {_name}\n" +
                $"Age: {_age}\n" +
                $"Weight: {_weight}\n" +
                $"Declawed: {_declawed}\n" +
                $"Adoption Date: {_adopt}\n" +
                $"Breed: {_type}\n";

            return info;
        }
        #endregion
    }
}
