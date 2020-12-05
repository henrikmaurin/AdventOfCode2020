using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020.Days
{
	public class Day3
	{
		private char[,] Map;
		private int MapSizeX;
		private int MapSizeY;

		public void Problem1()
		{
			List<string> mapData = File.ReadAllLines("Data/Day3.txt").ToList();
			ReadMap(mapData);
			int result = CountTrees(3, 1);

			Console.WriteLine(result);
		}
		public void Problem2()
		{
			List<string> mapData = File.ReadAllLines("Data/Day3.txt").ToList();
			ReadMap(mapData);

			long result = CountTrees(1, 1);
			result *= CountTrees(3, 1);
			result *= CountTrees(5, 1);
			result *= CountTrees(7, 1);
			result *= CountTrees(1, 2);

			Console.WriteLine(result);
		}


		

		public int CountTrees(int x, int y)
		{
			if (Map == null)
				return -1;

			int xpos = 0;
			int ypos = 0;
			int trees = 0;

			while (ypos < MapSizeY - 1)
			{
				xpos += x;
				ypos += y;
				if (GetAt(xpos, ypos) == '#')
					trees++;
			}

			return trees;
		}

		public char GetAt(int x, int y)
		{
			return Map[x % MapSizeX, y];
		}

		public char[,] ReadMap(List<string> mapLines)
		{
			MapSizeX = mapLines[0].Count();
			MapSizeY = mapLines.Count();

			Map = new char[MapSizeX, MapSizeY];
			int x = 0;
			int y = 0;
			foreach (string mapLine in mapLines)
			{
				foreach (char mapChar in mapLine)
				{
					Map[x, y] = mapChar;
					x++;
				}
				y++;
				x = 0;
			}
			return Map;
		}
	}
}
