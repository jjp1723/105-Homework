using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
	class Homework3Game : Game
	{
		// Example fields - remove these
		private int exampleX;
		private int exampleY;
        private List<Monster> monsters;

		/// <summary>
		/// Example constructor - Make this do whatever your game needs it to do
		/// </summary>
		public Homework3Game()
		{
			// Changes the console window's title
			Console.Title = "Welcome to the Homework 3 Game!";

			// ==============================
			

            monsters = new List<Monster>();
            Monster me = new Monster('I', 5, 5, ConsoleColor.Yellow);
            Minotaur bull = new Minotaur();
            Ghost phantom = new Ghost();
            Slime bob = new Slime();
            Random rng = new Random();
            Pixie bell = new Pixie(rng);

            monsters.Add(me);
            monsters.Add(bull);
            monsters.Add(phantom);
            monsters.Add(bob);
            monsters.Add(bell);
		}

		/// <summary>
		/// This method should update the game state, respond to user input, etc.
		/// 
		/// It should not actually "draw" (Console.Write or Console.WriteLine) anything
		/// to the screen.  That should happen in the Draw() method below.
		/// </summary>
		public override void Update()
		{
			// Pause to allow the user to see what's on the screen
			base.Update(); // Don't remove this

            //Updating the monsters
            foreach(Monster freaks in monsters)
            {
                freaks.Update();
            }

			// Ends the game if Escape is pressed
			if (KeyboardHelper.IsKeyDown(KeyCode.Escape))
			{
				GameOver = true;
			}

		}

		/// <summary>
		/// This method should handle "drawing" objects to the console window
		/// using Console.Write() or Console.WriteLine()
		/// 
		/// Remember: You can set the cursor's current position by using
		/// Console.CursorTop and Console.CursorLeft
		/// 
		/// You will get an error if you try to move the cursor outside
		/// the console's bounds.  You can find the bounds using
		/// Console.WindowWidth and Console.WindowHeight
		/// </summary>
		public override void Draw()
		{
			// Clears the screen
			base.Draw(); // Don't remove this

            //Drawing the monsters
            foreach (Monster freaks in monsters)
            {
                freaks.Draw();
            }

            // =========================
            // Replace the following code with your own

            // Print instructions to the screen
            Console.CursorLeft = 0;
            Console.CursorTop = 0;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press arrow keys to move");
		}

	}
}
