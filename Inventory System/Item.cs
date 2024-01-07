using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    enum ItemCategory
    {
        Food,
        Weapon,
        KeyItem
    }
    abstract class Item
    {
        //Fields
        protected string name;
        protected ItemCategory type;
        protected double weight;
        protected double value;

        //Field Properties
        //Name Property
        public string Name
        {
            get
            {
                return name;
            }
        }
        //Type Property
        public ItemCategory Type
        {
            get
            {
                return type;
            }
        }
        //Weight Property
        public double Weight
        {
            get
            {
                return weight;
            }
        }
        //Value Property
        public double Value
        {
            get
            {
                return value;
            }
        }

        //Parameterized Constructor
        public Item(string id, ItemCategory tp, double lbs, double val)
        {
            name = id;
            type = tp;
            weight = lbs;
            value = val;
        }

        //Abstract Use Method
        public abstract void Use();

        //Overriding ToString Method
        public override string ToString()
        {
            string special = "";
            switch(type)
            {
                case ItemCategory.Food:
                    special = name + ", a Food-type item, which weighs ";
                    break;
                case ItemCategory.Weapon:
                    special = name + ", a Weapon-type item, which weighs ";
                    break;
                case ItemCategory.KeyItem:
                    special = name + ", a Key Item, which weighs ";
                    break;
            }

            string basic = " pounds, and has a value of $";

            return (special + weight + basic + value);
        }
    }
}
