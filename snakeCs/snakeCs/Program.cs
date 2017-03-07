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

			Point p3 = new Point (2, 8, '$');
			p3.Draw ();

			List<char> charList = new List<char> ();
			charList.Add('@');
			charList.Add ('&');
			charList.Add ('^');
			charList.Add('$');

			char a = charList [0];
			char b = charList [1];
			char c = charList [2];
			char d = charList [3];

			foreach (char g in charList) {
				Console.WriteLine (g);
			}



			List<int> numList = new List<int> ();
			numList.Add (1);
			numList.Add (2);
			numList.Add (3);

			int x = numList [0];
			int y = numList [1];
			int z = numList [2];

			foreach (int i in numList) {
				Console.WriteLine ( i );
			}

			charList.RemoveAt (0);

			List<Point> pList = new List<Point> ();
			pList.Add (p1);
			pList.Add (p2);
			pList.Add (p3);
				
			Console.ReadLine ();
		}
	}
}
