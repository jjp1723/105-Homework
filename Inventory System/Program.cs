using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating a new Inventory Object and adding 10 Items to it
            Random rng = new Random();
            Inventory userInventory = new Inventory(rng);

            userInventory.Add(new Sword(404, 5, "Blade of Programmer's Bane", 2, 3.14));
            userInventory.Add(new Sandwich(7, "Gracies Burger", 0.5, 0.01));
            userInventory.Add(new Map(42, "RIT Campus", 2.2, 5.99));
            userInventory.Add(new Sword(999, 99, "Kitchen Knife", 0.01, 1.99));
            userInventory.Add(new Sandwich(16, "Sol's Chicken Parm", 1.3, 6.95));
            userInventory.Add(new Sandwich(11, "Manhatten Bagel Pork Roll", 1.01, 5.25));
            userInventory.Add(new Map(192, "Doylestown", 5.3, 10.99));
            userInventory.Add(new Sandwich(13, "Homemade Ham and Cheese", 0.85, 0.05));
            userInventory.Add(new Sandwich(1, "Hotdog", 0.67, 2.99));
            userInventory.Add(new Sword(1, 5, "Paper Blade", 0.10, 0.49));

            //Loop and Prompt fo User Input
            bool more = true;
            while (more)
            {
                Console.WriteLine("\nYour invetory currently has " + userInventory.Count + " items.\nWhich type of item would you like to use: Random, Weapon, Food, KeyItem");
                string response = Console.ReadLine().ToLower();
                bool invalid = true;

                //Using a Switch to ensure input was valid
                switch (response)
                {
                    //If the user entered "random", a random item is removed
                    case "random":
                        try
                        {
                            Item userItem = userInventory.RemoveRandomItem();
                            userItem.Use();

                            //Asking the user if they want to add the item back into the inventory
                            //Ensures the user enters "yes" or "no"
                            while(invalid)
                            {
                                Console.WriteLine("\nWould you like to put " + userItem.ToString() + " back in your inventory?");
                                string response2 = Console.ReadLine();

                                if (response2 == "yes")
                                {
                                    userInventory.Add(userItem);
                                    Console.WriteLine("\nYou put " + userItem.ToString() + " back in your inventory");
                                    invalid = false;
                                }
                                else if(response2 == "no")
                                {
                                    Console.WriteLine("\nYou did not put " + userItem.ToString() + " back in your inventory");
                                    invalid = false;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter \"yes\" or \"no\"");
                                }
                            }
                        }
                        catch
                        {
                            Console.WriteLine("\nSorry, no items are remaining in your inventory, enter \"Done\" to end program.");
                        }
                        break;

                    //If the user entered "weapon", a random weapon is removed
                    case "weapon":
                        try
                        {
                            Sword userSword = (Sword)userInventory.RemoveRandomItem(ItemCategory.Weapon);
                            userSword.Use();

                            //Asking the user if they want to add the item back into the inventory
                            //Ensures the user enters "yes" or "no"
                            while (invalid)
                            {
                                Console.WriteLine("\nWould you like to put " + userSword.ToString() + ", back in your inventory?");
                                string response3 = Console.ReadLine();

                                if (response3 == "yes")
                                {
                                    userInventory.Add(userSword);
                                    Console.WriteLine("\nYou put " + userSword.ToString() + ", back in your inventory");
                                    invalid = false;
                                }
                                else if (response3 == "no")
                                {
                                    Console.WriteLine("\nYou did not put " + userSword.ToString() + ", back in your inventory");
                                    invalid = false;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter \"yes\" or \"no\"");
                                }
                            }
                        }
                        catch
                        {
                            Console.WriteLine("\nSorry, no weapons are remaining in your inventory.");
                        }
                        break;

                    //If the user entered "food", a random food is removed
                    case "food":
                        try
                        {
                            Sandwich userSandwich = (Sandwich)userInventory.RemoveRandomItem(ItemCategory.Food);
                            userSandwich.Use();

                            //Asking the user if they want to add the item back into the inventory
                            //Ensures the user enters "yes" or "no"
                            while (invalid)
                            {
                                Console.WriteLine("\nWould you like to put " + userSandwich.ToString() + ", back in your inventory?");
                                string response4 = Console.ReadLine();

                                if (response4 == "yes")
                                {
                                    userInventory.Add(userSandwich);
                                    Console.WriteLine("\nYou put " + userSandwich.ToString() + ", back in your inventory");
                                    invalid = false;
                                }
                                else if (response4 == "no")
                                {
                                    Console.WriteLine("\nYou did not put " + userSandwich.ToString() + ", back in your inventory");
                                    invalid = false;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter \"yes\" or \"no\"");
                                }
                            }
                        }
                        catch
                        {
                            Console.WriteLine("\nSorry, no food is remaining in your inventory.");
                        }
                        break;

                    //If the user entered keyitem, a random keyitem is removed
                    case "keyitem":
                        try
                        {
                            Map userMap = (Map)userInventory.RemoveRandomItem(ItemCategory.KeyItem);
                            userMap.Use();

                            //Asking the user if they want to add the item back into the inventory
                            //Ensures the user enters "yes" or "no"
                            while (invalid)
                            {
                                Console.WriteLine("\nWould you like to put " + userMap.ToString() + ", back in your inventory?");
                                string response5 = Console.ReadLine();

                                if (response5 == "yes")
                                {
                                    userInventory.Add(userMap);
                                    Console.WriteLine("\nYou put " + userMap.ToString() + ", back in your inventory");
                                    invalid = false;
                                }
                                else if (response5 == "no")
                                {
                                    Console.WriteLine("\nYou did not put " + userMap.ToString() + ", back in your inventory");
                                    invalid = false;
                                }
                                else
                                {
                                    Console.WriteLine("Please enter \"yes\" or \"no\"");
                                }
                            }
                        }
                        catch
                        {
                            Console.WriteLine("\nSorry, no keyitems are remaining in your inventory.");
                        }
                        break;

                    //If the user enters "done", the program ends
                    case "done":
                        more = false;
                        Console.WriteLine("\n\n\nGoodbye!");
                        break;

                    //The default response
                    default:
                        Console.WriteLine("\nSorry, that input was not valid, try again.");
                        break;
                }
            }



            //Keeps Console Window Open
            Console.ReadLine();
        }
    }
}
