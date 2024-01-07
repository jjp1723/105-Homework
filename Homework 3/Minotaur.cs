using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Minotaur : Monster
    {
        //Constructor
        public Minotaur() : base('M', 10, 10, ConsoleColor.Red)
        {
        }

        //Overriding Update method which moves the minotaur in a square path
        public override void Update()
        {
            if(xCord == 10 && yCord < 20)
            {
                yCord++;
            }
            if(yCord == 20 && xCord < 30)
            {
                xCord++;
            }
            if(xCord == 30 && yCord > 10)
            {
                yCord--;
            }
            if(yCord == 10 && xCord > 10)
            {
                xCord--;
            }
        }
    }
}
