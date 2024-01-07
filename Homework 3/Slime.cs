using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Slime : Monster
    {
        //Fields
        private int moveX;
        private int moveY;

        //Constructor
        public Slime() : base('S', 22, 20, ConsoleColor.Green)
        {
            moveX = 1;
            moveY = 1;
        }

        //Overriding Update method which moves the slime around until it hits a wall, which it bounces off of
        public override void Update()
        {
            //Incrementing xCord until the slime hits a wall, then decrementing until it hits the other wall, etc.
            if(xCord > Console.WindowWidth - 2)
            {
                xCord = Console.WindowWidth - 1;
                moveX *= -1;
            }
            if(xCord < 1)
            {
                xCord = 0;
                moveX *= -1;
            }
            xCord += moveX;

            //Incrementing yCord until the slime hits a wall, then decrementing until it hits the other wall, etc.
            if(yCord > Console.WindowHeight - 2)
            {
                yCord = Console.WindowHeight - 1;
                moveY *= -1;
            }
            if(yCord < 1)
            {
                yCord = 1;
                moveY *= -1;
            }
            yCord += moveY;
        }
    }
}
