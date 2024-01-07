using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Pixie : Monster
    {
        //Field
        private Random rng;

        //Constructor
        public Pixie(Random rnj) : base('P', 75, 18, ConsoleColor.Magenta)
        {
            rng = rnj;
        }

        //Overriding update method which moves the pixie randomly
        public override void Update()
        {
            //Generates random value between -1 and 1 to move the pixie
            int moveX = rng.Next(4) - 2;
            int moveY = rng.Next(4) - 2;

            //Checking if the random value will move the pixie outside the console window
            if(xCord + moveX > Console.WindowWidth - 2)
            {
                xCord = Console.WindowWidth - 1;
            }
            else if(xCord + moveX < 0)
            {
                xCord = 1;
            }
            else
            {
                xCord += moveX;
            }

            //Checking if the random value will move the pixie outside the console window
            if (yCord + moveY > Console.WindowHeight - 2)
            {
                yCord = Console.WindowHeight - 1;
            }
            else if (yCord + moveY < 0)
            {
                yCord = 1;
            }
            else
            {
                yCord += moveY;
            }
        }
    }
}
