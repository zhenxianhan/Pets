using System;
namespace Pet
{
    public class dog
    {


        public string name;
        public string owner;
        public string weight;



        public dog( string name, string owner,string weight )
        {
            this.name = name;
            this.owner = owner;
            this.weight = weight;
         
        }

        public void Bark(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write("bark!");
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
