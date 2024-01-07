using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Sword : Item
    {
        //Fields
        protected int damage;
        protected int durability;

        //Field Properties
        //Damage Property
        public int Damage
        {
            get
            {
                return damage;
            }
        }
        //Durability Property
        public int Durability
        {
            get
            {
                return durability;
            }
        }

        //Parameterized Constructor
        public Sword(int dmg, int dur, string id, double lbs, double val):base(id, ItemCategory.Weapon, lbs, val)
        {
            damage = dmg;
            durability = dur;
        }

        //Overriding Abstract Use Method
        public override void Use()
        {
            if(durability > 0)
            {
                durability--;
                Console.WriteLine("You have swung " + base.ToString() + "  Only " + durability + " more swings and it will need to be repaired.");
            }
            else
            {
                Console.WriteLine("You attempted to swing " + base.ToString() + ", but it needs to be repaired so you decide against it.");
            }
        }

        //Overriding ToString Method
        public override string ToString()
        {
            return (base.ToString() + ".  It is a Sword that does " + damage + " damage and has a duability of " + durability);
        }
    }
}
