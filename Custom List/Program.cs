using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompting the user to enter a list size

            int big = 0;
            string size = "";

            bool parseable = true;
            while (parseable)
            {
                Console.WriteLine("List size?");
                size = Console.ReadLine();
                int value = 0;
                if (int.TryParse(size, out value) == true)
                {
                    big = int.Parse(size);
                    parseable = false;
                }
                else
                {
                    Console.WriteLine("\nYou did not enter a number, try again\n");
                }

            }

            CustomList<string> myList = new CustomList<string>(big);
            Console.WriteLine("The list size is " + size);

            //Keeps the program running until the user enters "done"
            bool play = true;
            while (play)
            {
                //Prompting the user to enter an item or one of the special commands
                Console.WriteLine("\nSpecial Commands:\n\"print\" - Prints every element in the list\n\"count\" - Counts how many elements are held within the list");
                Console.WriteLine("\"capacity\" - Returns the size of the list\n\"contains\" - Returns whether the list contains a specified element");
                Console.WriteLine("\"indexof\" - Returns the index of a specified element\n\"insert\" - Inserts a specified element at a valid specified index");
                Console.WriteLine("\"remove\" - Removes a specified element from the list\n\"removeat\" - Removes an element at a specified index");
                Console.WriteLine("\"get\" - Returns the element at a specified index\n\"set\" - Assigns an element to a specified index");
                Console.WriteLine("\"clear\" - Clears the entire list\n\"done\" - Ends the program\n");
                Console.WriteLine("Enter an item:");
                string word = Console.ReadLine();

                Console.WriteLine();

                //If the user enters "print", the print method is executed
                if (word.ToLower() == "print")
                {
                    myList.Print();
                }

                //If the user enters "count", the count property is called
                else if (word.ToLower() == "count")
                {
                    Console.WriteLine("Count: " + myList.Count);
                }

                //If the user enters "capacity", the capacity property is called
                else if (word.ToLower() == "capacity")
                {
                    Console.WriteLine("Capacity: " + myList.Capacity);
                }

                //If the user enters "get", the get property is used
                else if (word.ToLower() == "get")
                {
                    int indexGet = 0;
                    string theWord = "";

                    //Ensures the user inputs an integer
                    bool parseGet = true;
                    while (parseGet)
                    {
                        Console.WriteLine("Which index?");
                        theWord = Console.ReadLine();
                        int value = 0;
                        if (int.TryParse(theWord, out value) == true)
                        {
                            indexGet = int.Parse(theWord);
                            parseGet = false;
                        }
                        else
                        {
                            Console.WriteLine("\nYou did not enter a number, try again\n");
                        }

                    }

                    //Gets the string at the index
                    Console.WriteLine((string)(object)myList[indexGet]);
                }

                //If the user enters "set", the set property is used
                else if (word.ToLower() == "set")
                {
                    //Ensures the user inputs an integer
                    int indexSet = 0;
                    string theOtherWord = "";

                    bool parseSet = true;
                    while (parseSet)
                    {
                        Console.WriteLine("Which index?");
                        theOtherWord = Console.ReadLine();
                        int value = 0;
                        if (int.TryParse(theOtherWord, out value) == true)
                        {
                            indexSet = int.Parse(theOtherWord);
                            parseSet = false;
                        }
                        else
                        {
                            Console.WriteLine("\nYou did not enter a number, try again\n");
                        }
                    }

                    //Asks the user what they want to set this index to
                    Console.WriteLine("What should this index be set to?");
                    string setWord = Console.ReadLine();
                    myList[indexSet] = setWord;
                }

                //If the user enters "indexof", the IndexOf method is called
                else if(word.ToLower() == "indexof")
                {
                    Console.WriteLine("Word to search for:");
                    string search = Console.ReadLine();
                    int indexOf = myList.IndexOf(search);
                    Console.Write("The index of \"" + search + "\" is " + indexOf);

                    if (indexOf == -1)
                    {
                        Console.Write(" (it doesnt exist)");
                    }

                    Console.WriteLine();
                }

                //If the user enters "contains", the Contains method is called
                else if(word.ToLower() == "contains")
                {
                    Console.WriteLine("Word to search for:");
                    string there = Console.ReadLine();
                    bool contained = myList.Contains(there);

                    if(contained == true)
                    {
                        Console.WriteLine("\"" + there + "\" is in the list");
                    }
                    else
                    {
                        Console.WriteLine("\"" + there + "\" is NOT in the list");
                    }
                }

                //If the user enters "removeat", the RemoveAt method is called
                else if(word.ToLower() == "removeat")
                {
                    int removeAt = 0;
                    string remove;

                    //Ensures the user enters an integer
                    parseable = true;
                    while (parseable)
                    {
                        Console.WriteLine("Which index to remove?");
                        remove = Console.ReadLine();
                        int value = 0;
                        if (int.TryParse(remove, out value) == true)
                        {
                            removeAt = int.Parse(remove);
                            parseable = false;
                        }
                        else
                        {
                            Console.WriteLine("\nYou did not enter a number, try again\n");
                        }
                    }

                    if(removeAt < 0)
                    {
                        Console.WriteLine("That is not a valid index");
                    }
                    else
                    {
                        myList.RemoveAt(removeAt);
                        Console.WriteLine("Data at index " + removeAt + " removed");
                    }
                }

                //If the user enters "remove", the Remove method is called
                else if(word.ToLower() == "remove")
                {
                    Console.WriteLine("Word to remove:");
                    string removeWord = Console.ReadLine();

                    bool removed = myList.Remove(removeWord);

                    if(removed == true)
                    {
                        Console.WriteLine("\"" + removeWord + "\" was removed");
                    }
                    else
                    {
                        Console.WriteLine("\"" + removeWord + "\" was not found");
                    }
                }

                //If the user enters "insert", the insert method is called
                else if(word.ToLower() == "insert")
                {
                    Console.WriteLine("Which word to insert?");
                    string insert = Console.ReadLine();

                    int insertAt = 0;
                    string insertIndex;

                    //Ensures the user enters an integer
                    parseable = true;
                    while (parseable)
                    {
                        Console.WriteLine("Which index?");
                        insertIndex = Console.ReadLine();
                        int value = 0;
                        if (int.TryParse(insertIndex, out value) == true)
                        {
                            insertAt = int.Parse(insertIndex);
                            parseable = false;
                        }
                        else
                        {
                            Console.WriteLine("\nYou did not enter a number, try again\n");
                        }
                    }

                    //Performing the insertion
                    if(insertAt < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        myList.Insert(insertAt, insert);
                        Console.WriteLine("Inserted \"" + insert + "\" at index " + insertAt);
                    }
                }

                //If the user enters "clear", the Clear method is called
                else if(word.ToLower() == "clear")
                {
                    myList.Clear();
                    Console.WriteLine("List has been cleared");
                }

                //If the user enters "done", the program stops
                else if (word.ToLower() == "done")
                {
                    Console.WriteLine("Goodbye!");
                    play = false;
                }

                //If what the user enters does not match a special command, it is added to the list
                else
                {
                    myList.Add(word);
                }
            }
        }
    }
}
