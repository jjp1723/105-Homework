using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a default CustomDictionary
            CustomDictionary<string> dictionary = new CustomDictionary<string>();

            //Seeding 3 pairs with the Add Method
            dictionary.Add("John", "Awesome Dude");
            dictionary.Add("Krish", "Intelligent Idiot");
            dictionary.Add("Abbay", "Horse Eater");

            //Seeding 3 pairs with the Set Property
            dictionary["Jim"] = "Normal Man";
            dictionary["Pam"] = "Normal Woman";
            dictionary["Barf"] = "Dog Man";



            //Looping for user commands
            bool loop = true;
            while(loop)
            {
                //Prompting the user for input and storing it in a string
                Console.WriteLine("Please enter one of the following commands:");
                Console.WriteLine("Quit\tCount\tAdd\tRemove\tClear\tGet\tSet");
                string input = Console.ReadLine().ToLower();



                switch(input)
                {
                    //Code for "quit"
                    case "quit":
                        Console.WriteLine("\n\n\n\n\nGoodbye!");
                        loop = false;
                        break;



                    //Code for "count"
                    case "count":
                        Console.WriteLine("\nCurrent count: " + dictionary.Count + "\n\n\n");
                        break;



                    //Code for "add"
                    case "add":
                        //Prompting the user for a name which will act as a key
                        Console.WriteLine("\nPlease enter a name");
                        string name = Console.ReadLine();

                        //Prompting the user for a string which will be the value stored at said key
                        Console.WriteLine("\nPlease enter a string");
                        string value = Console.ReadLine();

                        //Adding the pair of "name" and "value" to the dictionary
                        Console.WriteLine("\nAdding the string \"" + value +"\" to the dictionary at the index of \"" + name + "\"\n\n\n");
                        dictionary.Add(name, value);
                        break;



                    //Code for "remove"
                    case "remove":
                        //Promting the user for a name they want removed
                        Console.WriteLine("\nPlease enter the name you want removed");
                        string remove = Console.ReadLine();

                        //If the Remove Method returns true, the name is removed from the dictionary
                        if(dictionary.Remove(remove))
                        {
                            dictionary.Remove(remove);
                            Console.WriteLine("\nRemoved \"" + remove + "\" from the dictionary\n\n\n");
                        }

                        //If the Remove Method doesn't return true, the program informs the user that the name was not found
                        else
                        {
                            Console.WriteLine("\nUnable to locate \"" + remove + "\" in the dictionary\n\n\n");
                        }
                        break;



                    //Code for "clear"
                    case "clear":
                        Console.WriteLine("\nClearing the dictionary\n\n\n");
                        dictionary.Clear();
                        break;



                    //Code for "get"
                    case "get":
                        //Prompting the user for what name they want to get the value of
                        Console.WriteLine("\nPlease enter the name you would like to get the value of the dictionary");
                        string getName = Console.ReadLine();

                        //Trying to get value of the provided name from the dictionary
                        try
                        {
                            string getValue = dictionary[getName];

                            //Printing the value stored in the dictionary
                            Console.WriteLine("\nFound \"" + getValue + "\" stored under \"" + getName + "\" in the dictionary\n\n\n");
                        }

                        //If the Get Indexer Property returns an error, the program will inform the user
                        catch
                        {
                            Console.WriteLine("\nUnable to locate \"" + getName + "\" in the dictionary\n\n\n");
                        }
                        break;



                    //Code for "set"
                    case "set":
                        //Promting the user for what name they would like to change the value of
                        Console.WriteLine("\nPlease enter the name you would like to set the value of in the dictionary");
                        string setName = Console.ReadLine();

                        //Prompting the user for the value they would like to store under the provided name
                        Console.WriteLine("\nPlease enter a string you would like to be stored under that name");
                        string setValue = Console.ReadLine();

                        //Trying to set value of the provided name from the dictionary
                        try
                        {
                            dictionary[setName] = setValue;

                            //Informing the user that the value stored under the provided name was seccessfully changed
                            Console.WriteLine("\nChanged the value stored under \"" + setName + "\" in the dictionary to \"" + setValue + "\"\n\n\n");
                        }

                        //If the Set Indexer Property returns an error, the program will inform the user
                        catch
                        {
                            Console.WriteLine("\nUnable to locate \"" + setName + "\" in the dictionary\n\n\n");
                        }
                        break;



                    //Code for any other input
                    default:
                        Console.WriteLine("\nUnknown Command\n\n\n");
                        break;
                }
            }



            //Keeps Console Window Open
            Console.ReadLine();
        }
    }
}
