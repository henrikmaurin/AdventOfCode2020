using AdventOfCode2020.Days;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests
{
	[TestClass]
	public class UnitTestDay3
	{
		[TestMethod]
		public void Example1()
		{
			List<string> mapdata = new List<string>
			{
				"..##.......",
				"#...#...#..",
				".#....#..#.",
				"..#.#...#.#",
				".#...##..#.",
				"..#.##.....",
				".#.#.#....#",
				".#........#",
				"#.##...#...",
				"#...##....#",
				".#..#...#.#"
			};

			Day3 day3 = new Day3();
			day3.ReadMap(mapdata);

			int result = day3.CountTrees(3, 1);

			Assert.AreEqual(7, result);
		}

		[TestMethod]
		public void Example2()
		{
			List<string> mapdata = new List<string>
			{
				"..##.......",
				"#...#...#..",
				".#....#..#.",
				"..#.#...#.#",
				".#...##..#.",
				"..#.##.....",
				".#.#.#....#",
				".#........#",
				"#.##...#...",
				"#...##....#",
				".#..#...#.#"
			};

			Day3 day3 = new Day3();
			day3.ReadMap(mapdata);

			int result = day3.CountTrees(1, 1);
			result *= day3.CountTrees(3, 1);
			result *= day3.CountTrees(5, 1);
			result *= day3.CountTrees(7, 1);
			result *= day3.CountTrees(1, 2);

			Assert.AreEqual(336, result);
		}
	}


}
