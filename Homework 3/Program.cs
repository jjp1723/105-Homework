using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create a new game and tell it to run
			Homework3Game game = new Homework3Game();
			game.GameLoop();
		}
	}
}
