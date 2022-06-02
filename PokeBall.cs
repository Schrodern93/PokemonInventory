using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonInventory
{
    internal class PokeBall: CatchingBall
    {

        public PokeBall():base("Pokeball", 12, true, 0.4)
        {
            
        }

        public override void useItem()
        {
            Console.WriteLine("Dette er pokeball " + Name);
        }
    }
}
