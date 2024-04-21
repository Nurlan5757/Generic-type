using Generic_type.Models;
using static Generic_type.Models.Animal;

namespace Generic_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wolf wolf = new Wolf(12, "basc", 100, Gender.male, true, 20);
            Elephant elephant = new Elephant(34, "bjc", 300, Gender.female, 150, true);
            Meat meat = new Meat(50, Meat.Type.Beef);
            Grass grass = new Grass(10,"ot");


            ZooCage<Wolf, Meat> zooCage = new(new Wolf[]
            {
                new Wolf ("ascy"),
                new Meat ("Beef")
            });

            /* wolf.Hunt(elephant);*/


        }
    }
}
