using System;

namespace Assessment_13_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] zoo = new Animal[3];

            zoo[0] = new Lion("Lion", "Leo", 10, 4);
            zoo[1] = new Fish("Fish", "Fred", 11, 0);
            zoo[2] = new Eagle("Fish","Eddie",12, 2);

            Lion Leo = (Lion)zoo[0];
            Fish Fred = (Fish)zoo[1];
            Eagle Eddie = (Eagle)zoo[2];

            for (int i = 0; i < zoo.Length; i++)
            {
                Console.WriteLine("SPECIES:" + " " + zoo[i].GetSpecies());
                Console.WriteLine("NAME:" + " " + zoo[i].GetName());
                Console.WriteLine("AGE:" + " " + zoo[i].GetAge());
                Console.WriteLine("LEGS:" + " " + zoo[i].GetLegs());
                zoo[i].Speak();
                Console.WriteLine("");
            }

            Console.WriteLine("LION ABILITY:" + " " + Leo.Run());
            Console.WriteLine("FISH ABILITY:" + " " + Fred.Swim());
            Console.WriteLine("EAGLE ABILITY:" + " " + Eddie.Fly());

        }
    }
}
