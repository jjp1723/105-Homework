using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Ghost : Monster
    {
        //Constructor
        public Ghost() : base('G', 20, 15, ConsoleColor.DarkBlue)
        {
        }

        //Overriding Update method which moves the ghost in a strait path until it hits a wall and wraps to the other side
        public override void Update()
        {
            if(xCord < Console.WindowWidth - 2)
            {
                xCord++;
            }
            else
            {
                xCord = 0;
            }
        }
    }
}
