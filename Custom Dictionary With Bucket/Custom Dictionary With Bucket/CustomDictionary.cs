using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Dictionary_With_Bucket
{
    class CustomDictionary<T>
    {
        //Fields
        protected List<CustomPair<T>>[] keyValues;
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

                //Looping through all stored pairs at the index of the provided key
                for(int keyList = 0; keyList < keyValues[index].Count; keyList++)
                {
                    //Checks that there is data at the index and that the key stored at that index matches key provided
                    if (keyValues[index][keyList] != null && keyValues[index][keyList].Key.Equals(key))
                    {
                        return keyValues[index][keyList].Value;
                    }
                }

                //If there is no data at they index or the key stored at that index doesn't match the provided key
                //the program throws a KeyNotFoundException
                throw new KeyNotFoundException();
            }

            set
            {
                //Running the key through the Hash function
                int index = this.Hash(key);

                //Checks that there is no data at the index before adding data to that index
                if (keyValues[index] == null)
                {
                    keyValues[index] = new List<CustomPair<T>>();
                    keyValues[index].Add(new CustomPair<T>(key, value));
                    count++;
                }

                //If there is data stored at the index, the program checks that the provided key matches any keys stored at the index before storing the new value
                else
                {
                    //Searching the List of CustomPairs at the provided index to find the provided key
                    foreach(CustomPair<T> pair in keyValues[index])
                    {
                        if(pair.Key.Equals(key))
                        {
                            pair.Value = value;
                        }
                    }
                }
            }
        }




        //Constructors
        //Default Constructor
        public CustomDictionary()
        {
            keyValues = new List<CustomPair<T>>[100];
            count = 0;
        }

        //Parameterized Constructor
        public CustomDictionary(int size)
        {
            keyValues = new List<CustomPair<T>>[size];
            count = 0;
        }



        //Methods
        //ContainsKey Method
        public bool ContainsKey(T key)
        {
            //If the key doesn't exist in the array, it returns False
            if (keyValues[this.Hash(key)] == null)
            {
                return false;
            }

            //If there is data at the corresponding key in the array, the program seaches it to find the provided key
            else
            {
                //Searching the List of CustomPairs at the provided index to find the provided key
                foreach (CustomPair<T> pair in keyValues[this.Hash(key)])
                {
                    //If the key is found in the list of CustomPairs, it returns true
                    if (pair.Key.Equals(key))
                    {
                        return true;
                    }
                }

                //If the key was not found in the list of CustomPairs, it returns false
                return false;
            }
        }

        //Add Method
        public void Add(T key, T value)
        {
            //Uses the COntainsKey Method to determine if the key if the provided key is already present in the dictionary
            //If the provided key is present, the method throws an ArgumentException with the appropriate message
            if(this.ContainsKey(key))
            {
                throw new ArgumentException("The key provided already exists in the dictionary");
            }

            //If the key doesn't exist in the array and there is no data at its associated index,
            //the method adds a new CustomPair List at the index associated with that key
            else if (keyValues[this.Hash(key)] == null)
            {
                keyValues[this.Hash(key)] = new List<CustomPair<T>>();
                keyValues[this.Hash(key)].Add(new CustomPair<T>(key, value));
                count++;
            }

            //If there is data at the corresponding key in the array and the provided key does not exist,
            //the method adds a new CustomPair to the List of CustomPairs in the array
            else
            {
                keyValues[this.Hash(key)].Add(new CustomPair<T>(key, value));
                count++;
            }
        }

        //Remove Method
        public bool Remove(T key)
        {
            //Makes sure that they provided key exists
            if (this.ContainsKey(key))
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
            for (int index = 0; index < keyValues.Length; index++)
            {
                //Setting the data at each index in the array to null
                keyValues[index] = null;
            }

            //Setting count to 0
            count = 0;
        }
    }
}
