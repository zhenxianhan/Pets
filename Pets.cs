using System;
namespace Pet
{
    public class Pets
    {
        public string type;
        public string name;
        public string owner;
        public string weight;



        public Pets( string type, string name, string owner, string weight )
        {
            this.type = type;
            this.name = name;
            this.owner = owner;
            this.weight = weight;

        }

       
        public string GetTag()
        {

            return String.Format("If lost, call {0}." ,
                                 owner);
        }
    }
}
