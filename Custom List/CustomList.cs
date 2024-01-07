using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    class CustomList<T>
    {
        //Fields
        private T[] customizedList;
        private int count;

        //Count 'get' property
        public int Count { get { return count; } }

        //Capacity 'get' property
        public int Capacity { get { return customizedList.Length; } }

        //Gets or sets individueal elements
        public T this[int index]
        {
            get
            {
                if (index < Capacity && index > -1)
                {
                    return customizedList[index];
                }
                else
                {
                    Console.WriteLine("Invalid index");
                    return default(T);
                }
            }

            set
            {
                if (index < count && index > -1)
                {
                    customizedList[index] = value;
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
        }

        //Parameterized Constructor
        public CustomList(int size)
        {
            customizedList = new T[size];
            count = 0;
        }

        //Default Constructor
        public CustomList() : this(4)
        {
        }

        //Add method
        public void Add(T item)
        {
            //If the list is full, a new list is created to store all items from customizedlist
            //customizedlist is then recreated at a larger size and all items are tranferred back
            if (count == Capacity)
            {
                T[] newList = new T[customizedList.Length + 1];
                
                for(int index = 0; index < count; index++)
                {
                    newList[index] = customizedList[index];
                }

                customizedList = new T[newList.Length];
                for (int index = 0; index < count + 1; index++)
                {
                    customizedList[index] = newList[index];
                }
            }
            
            customizedList[count] = item;
            count++;
            
        }

        //Print method
        public void Print()
        {
            //If the list is empty, "List is empty" is printed
            //Otherwise, all elements of the list are printed
            if(count == 0)
            {
                Console.WriteLine("List is empty");
            }

            for (int position = 0; position < count; position++)
            {
                Console.WriteLine(customizedList[position]);
            }
        }

        //IndexOf method
        public int IndexOf(string item)
        {
            for(int position = 0; position < count; position++)
            {
                if(item == (string)(object)customizedList[position])
                {
                    return position;
                }
            }

            return -1;
        }

        //Contains method
        public bool Contains(string item)
        {
            for (int position = 0; position < count; position++)
            {
                if (item == (string)(object)customizedList[position])
                {
                    return true;
                }
            }

            return false;
        }

        //RemoveAt method
        public void RemoveAt(int index)
        {
            //Does nothing if the index is less than zero or greater than current count
            if(index > count || index < 0)
            {
                return;
            }

            for(int replace = index; replace + 1 < count; replace++)
            {
                customizedList[replace] = customizedList[replace + 1];
            }

            count--;
            return;
        }

        //Remove method
        public bool Remove(string item)
        {
            for (int position = 0; position < count; position++)
            {
                if (item == (string)(object)customizedList[position])
                {
                    for (int replace = position; replace + 1 < count; replace++)
                    {
                        customizedList[replace] = customizedList[replace + 1];
                    }

                    count--;
                    return true;
                }
            }

            return false;
        }

        //Insert method
        public void Insert(int index, T item)
        {
            if(index < 0)
            {
                return;
            }

            if(index >= count)
            {
                index = count;

                if (count == Capacity)
                {
                    T[] newerList = new T[customizedList.Length + 1];

                    for (int position = 0; position < count; position++)
                    {
                        newerList[position] = customizedList[position];
                    }

                    customizedList = new T[newerList.Length];
                    for (int position = 0; position < count + 1; position++)
                    {
                        customizedList[position] = newerList[position];
                    }
                }

                customizedList[count] = item;
                count++;

                return;
            }

            //Inserting within the existing list
            
            T[] newList = new T[customizedList.Length + 1];

            for (int position = 0; position < index; position++)
            {
                    newList[position] = customizedList[position];
            }
            for (int position = index; position < count; position++)
            {
                newList[position + 1] = customizedList[position];
            }

            newList[index] = item;

            customizedList = new T[newList.Length];
            for (int position = 0; position < count + 1; position++)
            {
                    customizedList[position] = newList[position];
            }

            count++;
            return;
        }

        //Clear method
        public void Clear()
        {
            int size = customizedList.Length;
            customizedList = new T[size];
            count = 0;
        }
    }
}
