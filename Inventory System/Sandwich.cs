using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Sandwich : Item
    {
        //Fields
        protected int bites;

        //Field Properties
        //Bites Property
        public int Bites
        {
            get
            {
                return bites;
            }
        }

        //Parameterized Constructor
        public Sandwich(int bt, string id, double lbs, double val):base(id, ItemCategory.Food, lbs, val)
        {
            bites = bt;
        }

        //Overriding Abstract Use Method
        public override void Use()
        {
            if(bites > 0)
            {
                bites--;
                Console.WriteLine("You took a bite out of " + base.ToString() + ".  It was delicious, but now you have " + bites + " bites left.");
            }
            else
            {
                Console.WriteLine("You wanted to take a bite out of " + base.ToString() + ", but you already at the whole thing!");
            }
        }

        //Overriding ToString Method
        public override string ToString()
        {
            return (base.ToString() + ".  It is a delicious sandwich that you will finish in about " + bites + " more bites");
        }
    }
}
