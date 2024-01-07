using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Inventory
    {
        //Fields
        protected List<Item> itemList;
        protected Random rng;

        //Parameterized constructor
        public Inventory(Random rnj)
        {
            itemList = new List<Item>();
            rng = rnj;
        }

        //Count Property
        public int Count
        {
            get
            {
                return itemList.Count;
            }
        }

        //Add Method
        public void Add(Item item)
        {
            itemList.Add(item);
        }

        //RemoveRandomItem Method
        public Item RemoveRandomItem()
        {
            int index = rng.Next(itemList.Count + 1);
            Item remove = itemList[index];
            itemList.RemoveAt(index);
            return remove;
        }

        //RemoveRandomItem Category Method
        public Item RemoveRandomItem(ItemCategory category)
        {
            //Creating a mini List<Item> specialItems that will hold all Items of the specified category
            //Creating a int List to hold the indexes of the the Items added into specialItems
            List<Item> specialItems = new List<Item>();
            List<int> indexes = new List<int>();

            foreach(Item item in itemList)
            {
                if(item.Type == category)
                {
                    specialItems.Add(item);
                    indexes.Add(itemList.IndexOf(item));
                }
            }

            //Selecting a random item from mini List<Item> specialItems and using its stored index in List<int> indexes to remove it from myItems
            int index = rng.Next(specialItems.Count);
            Item remove = specialItems[index];
            int removeIndex = indexes[index];
            itemList.RemoveAt(removeIndex);
            return remove;
        }
    }
}
