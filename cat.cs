using System;
namespace Pet
{
    public class cat
    {

        public string owner;
        public string name;
        public string weight;
       


        public cat( string name, string owner, string weight )
        {
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        }

        public void Meow(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write("Meow.");
            }
            Console.WriteLine("");
        }

        public string GetTag()
        {

            return String.Format("If lost, call {0}." ,
                                 owner);
        }
    }
}
