using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Monster
    {
        //Fields
        protected char monsty;
        protected int xCord;
        protected int yCord;
        protected ConsoleColor pretty;

        //monsty get/set property
        public char Monsty
        {
            get
            {
                return monsty;
            }
            set
            {
                monsty = value;
            }
        }

        //xCord get/set proptery
        public int XCord
        {
            get
            {
                return xCord;
            }
            set
            {
                xCord = value;
            }
        }

        //yCord get/set property
        public int YCord
        {
            get
            {
                return yCord;
            }
            set
            {
                yCord = value;
            }
        }

        //pretty get/set property
        public ConsoleColor Pretty
        {
            get
            {
                return pretty;
            }
            set
            {
                pretty = value;
            }
        }

        //Parameterized constructor
        public Monster(char monster, int x, int y, ConsoleColor beauty)
        {
            monsty = monster;
            xCord = x;
            yCord = y;
            pretty = beauty;
        }

        //Draw method
        public void Draw()
        {
            Console.CursorLeft = xCord;
            Console.CursorTop = yCord;
            Console.ForegroundColor = pretty;
            Console.Write(monsty);
        }

        //Update Method
        public virtual void Update()
        {
            if (KeyboardHelper.IsKeyDown(KeyCode.Left))
            {
                xCord--;
                if (xCord < 0)
                    xCord = 0;
            }

            if (KeyboardHelper.IsKeyDown(KeyCode.Right))
            {
                xCord++;
                if (xCord >= Console.WindowWidth)
                    xCord = Console.WindowWidth - 1;
            }

            if (KeyboardHelper.IsKeyDown(KeyCode.Up))
            {
                yCord--;
                if (yCord < 1)
                    yCord = 1;
            }

            if (KeyboardHelper.IsKeyDown(KeyCode.Down))
            {
                yCord++;
                if (yCord >= Console.WindowHeight)
                    yCord = Console.WindowHeight - 1;
            }
        }
    }
}
