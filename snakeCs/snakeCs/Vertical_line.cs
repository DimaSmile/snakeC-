using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeCs
{
	public class Vertical_line
	{

		List<Point> pList;

		public Vertical_line (int x, int yUp, int yDown, char sym)
		{
			pList = new List<Point> ();
			pList = new List<Point> ();
			for (int y = yUp; y <= yDown; y++) {
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

