using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Map : Item
    {
        //Fields
        protected int locations;

        //Field Properties
        //Visits Property
        public int Visits
        {
            get
            {
                return locations;
            }
        }

        //Parameterized Constrictor
        public Map(int local, string id, double lbs, double val):base(id, ItemCategory.KeyItem, lbs, val)
        {
            locations = local;
        }

        //Overriding Abstract Use Method
        public override void Use()
        {
            if(locations > 0)
            {
                locations--;
                Console.WriteLine("You used " + base.ToString() + ", and found a new location to visit.  There are now " + locations + " locations left for you to visit.");
            }
            else
            {
                Console.WriteLine("You tried to use " + base.ToString() + " to find a new location to visit, but you already went everywhere!");
            }
        }

        //Overriding ToString Method
        public override string ToString()
        {
            return (base.ToString() + ".  It is a map that shows " + locations + " locations you have yet to visit");
        }
    }
}
