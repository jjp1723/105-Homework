using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Activity 1
            
            //Creating Dungeon
            Dungeon activity1 = new Dungeon(40, 30, "Activity 1");

            //Creating the first chamber
            activity1.DrawObject(0, 0, '╔');
            activity1.DrawObject(0, 11, '╚');
            activity1.DrawObject(11, 0, '╗');
            activity1.DrawObject(11, 11, '╝');
            activity1.DrawWallVerticle(0, 1, 10);
            activity1.DrawWallHorizontal(1, 11, 10);
            activity1.DrawWallHorizontal(1, 0, 10);
            activity1.DrawWallVerticle(11, 1, 3);
            activity1.DrawWallVerticle(11, 8, 3);

            //Creating the Hallway
            activity1.DrawObject(11, 4, '╚');
            activity1.DrawObject(11, 7, '╔');
            activity1.DrawObject(22, 4, '╝');
            activity1.DrawObject(22, 7, '╗');
            activity1.DrawWallHorizontal(12, 4, 10);
            activity1.DrawWallHorizontal(12, 7, 10);

            //Creating the second chamber
            activity1.DrawObject(22, 2, '╔');
            activity1.DrawObject(33, 2, '╗');
            activity1.DrawObject(33, 13, '╝');
            activity1.DrawObject(22, 13, '╚');
            activity1.DrawWallVerticle(22, 3, 1);
            activity1.DrawWallHorizontal(23, 2, 10);
            activity1.DrawWallVerticle(33, 3, 10);
            activity1.DrawWallVerticle(22, 8, 5);
            activity1.DrawWallHorizontal(23, 13, 10);

            //Creating objects within the dungeon chambers
            Console.ForegroundColor = ConsoleColor.Cyan;
            activity1.DrawObject(3, 3, '@');
            Console.ForegroundColor = ConsoleColor.Green;
            activity1.DrawObject(8, 9, 'W');
            Console.ForegroundColor = ConsoleColor.Magenta;
            activity1.DrawObject(25, 6, 'P');
            Console.ForegroundColor = ConsoleColor.Red;
            activity1.DrawObject(27, 6, '*');
            activity1.DrawObject(28, 5, '*');
            activity1.DrawObject(29, 6, '*');
            Console.ForegroundColor = ConsoleColor.Yellow;
            activity1.DrawObject(28, 10, 'M');
            */





            //Activity 2

            //Creating Dungeon
            Dungeon activity2 = new Dungeon(40, 30, "Activity 2");

            //Creating the first chamber
            activity2.DrawObjectOptional(0, 0, '╔');
            activity2.DrawObjectOptional(0, 11, '╚');
            activity2.DrawObjectOptional(11, 0, '╗');
            activity2.DrawObjectOptional(11, 11, '╝');
            activity2.DrawWallHorizontalOptional(1, 11, 10);
            activity2.DrawWallHorizontalOptional(1, 0, 10);
            activity2.DrawWallVerticleOptional(0, 1, 10);
            activity2.DrawWallVerticleOptional(11, 1, 3);
            activity2.DrawWallVerticleOptional(11, 8, 3, '>', ConsoleColor.DarkGreen);

            //Creating the Hallway
            activity2.DrawObjectOptional(11, 4, '╚');
            activity2.DrawObjectOptional(11, 7, '╔');
            activity2.DrawObjectOptional(22, 4, '╝');
            activity2.DrawObjectOptional(22, 7, '╗');
            activity2.DrawWallHorizontalOptional(12, 4, 10, '~', ConsoleColor.Red);
            activity2.DrawWallHorizontalOptional(12, 7, 10);

            //Creating the second chamber
            activity2.DrawObjectOptional(22, 2, '╔');
            activity2.DrawObjectOptional(33, 2, '╗');
            activity2.DrawObjectOptional(33, 13, '╝');
            activity2.DrawObjectOptional(22, 13, '╚');
            activity2.DrawWallVerticleOptional(33, 3, 10);
            activity2.DrawWallVerticleOptional(22, 8, 5);
            activity2.DrawWallVerticleOptional(22, 3, 1, '|', ConsoleColor.Blue);
            activity2.DrawWallHorizontalOptional(23, 2, 10);
            activity2.DrawWallHorizontalOptional(23, 13, 10);

            //Creating objects within the dungeon chambers
            activity2.DrawObjectOptional(3, 3, '@', ConsoleColor.Cyan);
            activity2.DrawObjectOptional(8, 9, 'W', ConsoleColor.Green);
            activity2.DrawObjectOptional(25, 6, 'P', ConsoleColor.Magenta);
            activity2.DrawObjectOptional(27, 6, '*', ConsoleColor.Red);
            activity2.DrawObjectOptional(28, 5, '*', ConsoleColor.Red);
            activity2.DrawObjectOptional(29, 6, '*', ConsoleColor.Red);
            activity2.DrawObjectOptional(28, 10, 'M', ConsoleColor.Yellow);



            



            //Keeps window open
            Console.ReadLine();
        }
    }
}
