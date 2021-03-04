using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_13_Zoo
{
    class Eagle : Animal
    {

        public Eagle(string species, string name, int age, int legs)
        {
            this.species = species;
            this.name = name;
            this.age = age;
            this.legs = legs;
        }

        public string Fly()
        {
            
            return ("I can fly.");
        }

        public override void Speak()
        {
            Console.WriteLine("Eeekk.");
        }
    }
}
