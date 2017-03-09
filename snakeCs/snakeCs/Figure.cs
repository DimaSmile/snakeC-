using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace snakeCs
{
	class Figure
	{
		protected List<Point> pList;

		public 	void Drow(){ //Метод Drow
			foreach (Point p in pList) {
				p.Draw (); 
			}
		}
	}
}

