using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Dictionary
{
    class CustomDictionary<T>
    {
        //Fields
        protected CustomPair<T>[] keyValues;
        protected int count;



        //Hash Function
        public int Hash(T code)
        {
            return Math.Abs(code.GetHashCode()) % keyValues.Length;
        }



        //Properties
        //Count Property
        public int Count
        {
            get
            {
                return count;
            }
        }

        //Indexer Property
        public T this[T key]
        {
            get
            {
                //Running the key through the Hash function
                int index = this.Hash(key);

                //Checks that there is data at the index and that the key stored at that index matches key provided
                if(keyValues[index] != null && keyValues[index].Key.Equals(key))
                {
                    return keyValues[index].Value;
                }

                //If there is no data at they index or the key stored at that index doesn't match the provided key
                //the program throws a KeyNotFoundException
                else
                {
                    throw new KeyNotFoundException();
                }
            }

            set
            {
                //Running the key through the Hash function
                int index = this.Hash(key);

                //Checks that there is no data at the index before adding data to that index
                if(keyValues[index] == null)
                {
                    keyValues[index] = new CustomPair<T>(key, value);
                    count++;
                }

                //If there is data stored at the index, the program checks that the provided key matches the key stored at the index before storing the new value at that index
                else if (keyValues[index].Key.Equals(key))
                {
                    keyValues[index].Value = value;
                }

                //If there is data at they index data stored at that index doesn't match the data with provided key
                //the program throws a KeyNotFoundException
                else
                {
                    throw new AggregateException();
                }
            }
        }




        //Constructors
        //Default Constructor
        public CustomDictionary()
        {
            keyValues = new CustomPair<T>[100];
            count = 0;
        }

        //Parameterized Constructor
        public CustomDictionary(int size)
        {
            keyValues = new CustomPair<T>[size];
            count = 0;
        }



        //Methods
        //ContainsKey Method
        public bool ContainsKey(T key)
        {
            //If the key doesn't exist in the array, it returns False
            if(keyValues[this.Hash(key)] == null)
            {
                return false;
            }

            //If the key does exist in the array and it matches the key provided, it returns True
            else if(keyValues[this.Hash(key)].Key.Equals(key))
            {
                return true;
            }

            //If the key does exist but there is a key at its respective index in the array that does not match the key provided, it returns False
            //This is a Collision
            else
            {
                return false;
            }
        }

        //Add Method
        public void Add(T key, T value)
        {
            //If the key doesn't exist in the array, it adds a new CustomPair at the index associated with that key
            if (keyValues[this.Hash(key)] == null)
            {
                keyValues[this.Hash(key)] = new CustomPair<T>(key, value);
                count++;
            }

            //If the key does exist in the array, it throws an exception with the appropriate message
            else if(keyValues[this.Hash(key)].Key.Equals(key))
            {
                throw new ArgumentException("The key provided already exists in the dictionary");
            }

            //If there is a collision, it throws an exception with the appropriate message
            else
            {
                throw new ArgumentException("There was a collision in the dictionary");
            }
        }

        //Remove Method
        public bool Remove(T key)
        {
            //Makes sure that they provided key exists
            if(this.ContainsKey(key))
            {
                int hashKey = this.Hash(key);

                //Replacing the data in the array with null to remove it
                keyValues[hashKey] = null;

                //decrementing count to reflect the removal of data and returning True
                count--;
                return true;
            }

            //If they key provided doesn't exist, the method returns False
            else
            {
                return false;
            }
        }

        //Clear Method
        public void Clear()
        {
            //Looping through the entire array
            for(int index = 0; index < keyValues.Length; index++)
            {
                //Setting the data at each index in the array to null
                keyValues[index] = null;
            }

            //Setting count to 0
            count = 0;
        }
    }
}
