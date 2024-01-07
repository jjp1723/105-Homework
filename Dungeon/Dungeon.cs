using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class Dungeon
    {
        //Fields
        private int windowWidth;
        private int windowHeight;

        //Constructor
        public Dungeon(int width, int height, string name)
        {
            if(width > 100)
            {
                windowWidth = 100;
            }
            else
            {
                windowWidth = width;
            }
            
            if(height > 60)
            {
                windowHeight = 60;
            }
            else
            {
                windowHeight = height;
            }

            Console.Title = name;
        }



        //DrawWallVerticle Method
        public void DrawWallVerticle(int x, int y, int length)
        {
            //Ensuring the length will fit inside the window
            if(length > windowHeight)
            {
                length = windowHeight;
            }

            //Ensuring the x coordinate is within the window
            if (x > windowWidth)
            {
                Console.CursorLeft = windowWidth;
            }
            else if(x < 0)
            {
                Console.CursorLeft = 0;
            }
            else
            {
                Console.CursorLeft = x;
            }

            //Ensuring the y coordinate is within the window
            if((y + length) > windowHeight)
            {
                Console.CursorTop = windowHeight - length;
            }
            else if(y < 0)
            {
                Console.CursorTop = 0;
            }
            else
            {
                Console.CursorTop = y;
            }
            


            //Loop that draws the wall
            for(int high = 0; high < length; high++)
            {
                Console.WriteLine("║");
                Console.CursorLeft = x;
            }
        }



        //DrawWallHorizontal method
        public void DrawWallHorizontal(int x, int y, int length)
        {
            //Ensuring the length will fit inside the window
            if (length > windowWidth)
            {
                length = windowWidth;
            }

            //Ensuring the x coordinate is within the window
            if ((x + length) > windowWidth)
            {
                Console.CursorLeft = windowWidth - length;
            }
            else if (x < 0)
            {
                Console.CursorLeft = 0;
            }
            else
            {
                Console.CursorLeft = x;
            }

            //Ensuring the y coordinate is within the window
            if (y > windowHeight)
            {
                Console.CursorTop = windowHeight;
            }
            else if (y < 0)
            {
                Console.CursorTop = 0;
            }
            else
            {
                Console.CursorTop = y;
            }



            //Loop that draws the wall
            for (int wide = 0; wide < length; wide++)
            {
                Console.Write("═");
            }
        }



        //DrawObject method
        public void DrawObject(int x, int y, char symbol)
        {
            //Ensuring the x coordinate is within the window
            if (x > windowWidth)
            {
                Console.CursorLeft = windowWidth;
            }
            else if (x < 0)
            {
                Console.CursorLeft = 0;
            }
            else
            {
                Console.CursorLeft = x;
            }

            //Ensuring the y coordinate is within the window
            if (y > windowHeight)
            {
                Console.CursorTop = windowHeight;
            }
            else if (y < 0)
            {
                Console.CursorTop = 0;
            }
            else
            {
                Console.CursorTop = y;
            }



            Console.Write(symbol);
        }





        //DrawWallVerticle Method with optional parameters
        public void DrawWallVerticleOptional(int x, int y, int length, char wall = '║', ConsoleColor pretty = ConsoleColor.White)
        {
            //Ensuring the length will fit inside the window
            if (length > windowHeight)
            {
                length = windowHeight;
            }

            //Ensuring the x coordinate is within the window
            if (x > windowWidth)
            {
                Console.CursorLeft = windowWidth;
            }
            else if (x < 0)
            {
                Console.CursorLeft = 0;
            }
            else
            {
                Console.CursorLeft = x;
            }

            //Ensuring the y coordinate is within the window
            if ((y + length) > windowHeight)
            {
                Console.CursorTop = windowHeight - length;
            }
            else if (y < 0)
            {
                Console.CursorTop = 0;
            }
            else
            {
                Console.CursorTop = y;
            }

            //Setting foreground color to optional input
            Console.ForegroundColor = pretty;

            //Loop that draws the wall
            for (int high = 0; high < length; high++)
            {
                Console.WriteLine(wall);
                Console.CursorLeft = x;
            }

            //Setting color to default
            Console.ForegroundColor = ConsoleColor.White;
        }



        //DrawWallHorizontal method with optional parameters
        public void DrawWallHorizontalOptional(int x, int y, int length, char wall = '═', ConsoleColor pretty = ConsoleColor.White)
        {
            //Ensuring the length will fit inside the window
            if (length > windowWidth)
            {
                length = windowWidth;
            }

            //Ensuring the x coordinate is within the window
            if ((x + length) > windowWidth)
            {
                Console.CursorLeft = windowWidth - length;
            }
            else if (x < 0)
            {
                Console.CursorLeft = 0;
            }
            else
            {
                Console.CursorLeft = x;
            }

            //Ensuring the y coordinate is within the window
            if (y > windowHeight)
            {
                Console.CursorTop = windowHeight;
            }
            else if (y < 0)
            {
                Console.CursorTop = 0;
            }
            else
            {
                Console.CursorTop = y;
            }

            //Setting color to optional input
            Console.ForegroundColor = pretty;

            //Loop that draws the wall
            for (int wide = 0; wide < length; wide++)
            {
                Console.Write(wall);
            }

            //Setting color to default
            Console.ForegroundColor = ConsoleColor.White;
        }



        //DrawObject method with optional parameters
        public void DrawObjectOptional(int x, int y, char symbol = ' ', ConsoleColor pretty = ConsoleColor.White)
        {
            //Ensuring the x coordinate is within the window
            if (x > windowWidth)
            {
                Console.CursorLeft = windowWidth;
            }
            else if (x < 0)
            {
                Console.CursorLeft = 0;
            }
            else
            {
                Console.CursorLeft = x;
            }

            //Ensuring the y coordinate is within the window
            if (y > windowHeight)
            {
                Console.CursorTop = windowHeight;
            }
            else if (y < 0)
            {
                Console.CursorTop = 0;
            }
            else
            {
                Console.CursorTop = y;
            }

            Console.ForegroundColor = pretty;

            Console.Write(symbol);
            
            //Changes color back to default
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
