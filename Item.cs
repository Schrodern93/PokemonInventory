using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonInventory
{
    internal abstract class Item
    {
        public string Name;
        protected int Id;
        protected bool CanBeUsedInBattle;
        
        public Item(string name, int id, bool canBeUsedInBattle)
        {
            Name = name;
            Id = id;
            CanBeUsedInBattle = canBeUsedInBattle;

        }

        //public abstract void useItem();
        public virtual void useItem()
        {
            Console.WriteLine("You used " + Name);

        }


    }
}
