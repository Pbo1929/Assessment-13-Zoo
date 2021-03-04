using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_13_Zoo
{
    class Fish : Animal
    {

        public Fish(string species, string name, int age, int legs)
        {
            this.species = species;
            this.name = name;
            this.age = age;
            this.legs = legs;
        }

        public string Swim()
        {
            
            return ("I can swim.");
            
        }

        public override void Speak()
        {
            Console.WriteLine("Glug Glug.");
        }
    }
}
