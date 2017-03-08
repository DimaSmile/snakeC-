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
			Console.SetWindowSize(80, 25);

			//Border

			Horisontal_line upline = new Horisontal_line (0, Console.BufferWidth-1, 0, '+');
			upline.Drow ();
			Horisontal_line downline = new Horisontal_line (0, Console.BufferWidth-1, Console.BufferHeight-2, '+');
			downline.Drow ();

			Vertical_line lline = new Vertical_line (0, Console.BufferHeight-1, 0, '+');
			lline.Drow();
			Vertical_line rline = new Vertical_line  (0, Console.BufferHeight-1, Console.BufferWidth-1, '+');
			rline.Drow();

			//Отрисовка точек
			Point p = new Point (4, 5, '*');
			Snake snake = new Snake(p, 4, Direction.RIGHT);
			snake.Drow ();


			Console.ReadLine ();
		}
	}
}
