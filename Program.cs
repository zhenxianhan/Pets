using System;

namespace Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pets pet1 = new Pets("dog", "Shadow", "Jose", "42.6");

            Console.WriteLine("Name: " + pet1.name);
            Console.WriteLine("weight: pet" + pet1.weight);
            Console.WriteLine(pet1.GetTag());
            Console.WriteLine("");



            dog dog1 = new dog("Daisy", "Kent", "23.4");

            Console.WriteLine("Name: " + dog1.name);
            Console.WriteLine("weight: " + dog1.weight);
            Console.WriteLine(dog1.GetTag());
            dog1.Bark(4);
            Console.WriteLine("");

            cat cat1 = new cat("Simba", "Maria", "5.2");

            Console.WriteLine("Name: " + cat1.name);
            Console.WriteLine("weight: " + cat1.weight);
            Console.WriteLine(cat1.GetTag());
            cat1.Meow(3);
            Console.WriteLine("");
        }
    }
}
    