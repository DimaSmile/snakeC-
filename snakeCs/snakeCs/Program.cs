using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeCs
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Point p1 = new Point (1, 3, '*');
			p1.Draw ();


			Point p2 = new Point (4, 5, '#');
			p2.Draw ();

			Horisontal_line line = new Horisontal_line (5, 10, 8, '+');
			line.Drow ();

			Vertical_line dline = new Vertical_line(7,0, 5, '+');
			dline.Drow();
				
			Console.ReadLine ();
		}
	}
}
