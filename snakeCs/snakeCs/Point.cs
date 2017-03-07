using System;

namespace snakeCs
{
	class Point{

		public int x;
		public int y;
		public char sym;

		public void Draw()
		{
			Console.SetCursorPosition (x, y);
			Console.WriteLine (sym);
		}

	}
}

