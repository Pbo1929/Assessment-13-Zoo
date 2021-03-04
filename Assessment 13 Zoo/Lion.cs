using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_13_Zoo
{
    class Lion : Animal
    {

        public Lion(string species, string name, int age, int legs)
        {
            this.species = species;
            this.name = name;
            this.age = age;
            this.legs = legs;
        }

        public string Run()
        {
            
            return ("I can run.");
        }

        public override void Speak()
        {
            Console.WriteLine("Roar.");
        }
    }
}
