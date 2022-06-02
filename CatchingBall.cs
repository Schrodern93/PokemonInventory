using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonInventory
{
    internal abstract class CatchingBall :Item
    {
        protected double Catchrate;

        public CatchingBall( string name, int id, bool canBeUsedInBattle, double catchrate) 
            :base( name, id,canBeUsedInBattle)
        {
            Catchrate = catchrate;
        }

        // catch rate equation 


    }
}
