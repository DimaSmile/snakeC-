using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeCs
{
	public class Horisontal_line
	{

		List<Point> pList;

		public Horisontal_line (int xLeft, int xReight, int y, char sym)
		{
			pList = new List<Point> ();
			for (int x = xLeft; x <= xReight; x++) {
				Point p = new Point (x, y, sym);
				pList.Add (p);
			}

		}
		public 	void Drow(){ //Метод Drow
			foreach (Point p in pList) {
				p.Draw (); 
			}
		}
	}
}

