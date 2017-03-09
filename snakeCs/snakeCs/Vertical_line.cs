using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace snakeCs
{
	class Vertical_line : Figure
	{

		public Vertical_line ( int yUp, int yDown, int x, char sym)
		{
			pList = new List<Point> ();
			for (int y = yUp; y <= yDown; y++) {
				Point p = new Point (x, y, sym);
				pList.Add (p);

			}
		}
	}
}

