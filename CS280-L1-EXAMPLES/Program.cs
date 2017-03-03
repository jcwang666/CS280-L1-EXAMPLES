using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_L1_EXAMPLES
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            pokemon.Height = 2.0f;
            pokemon.Weight = 12.7f;
            pokemon.Category = "Lizard";
            pokemon.Abilities = "Blaze";
            pokemon.Gender = "M";

            Console.WriteLine("HELLO WORLD");
            Console.WriteLine("HELLO WORLD2222");
            Console.WriteLine("HELLO WORLD23333");
            Console.WriteLine("height:{0} , weight:{1}", pokemon.Height, pokemon.Weight);
        }
    }
}