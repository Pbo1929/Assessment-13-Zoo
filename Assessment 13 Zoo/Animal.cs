using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_13_Zoo
{
    class Animal
    {
        protected string species;
        protected string name;
        protected int age;
        protected int legs;

        public string GetSpecies()
        {
            return species;
        }

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public int GetLegs()
        {
            return legs;
        }

        public virtual void Speak()
        {
            Console.WriteLine("Woof.");
        }
    }
}
