using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace snakeCs
{
	class Horisontal_line : Figure
	{

		public Horisontal_line (int xLeft, int xReight, int y, char sym)
		{
			pList = new List<Point> ();
			for (int x = xLeft; x <= xReight; x++) {
				Point p = new Point (x, y, sym);
				pList.Add (p);
			}
		}
	}
}

