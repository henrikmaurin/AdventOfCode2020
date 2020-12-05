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

			int result = Day3.CountTrees(3, 1, Day3.ReadMap(mapdata));
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

			Day3.Map map = Day3.ReadMap(mapdata);

			int result = Day3.CountTrees(1, 1, map);
			result *= Day3.CountTrees(3, 1, map);
			result *= Day3.CountTrees(5, 1, map);
			result *= Day3.CountTrees(7, 1, map);
			result *= Day3.CountTrees(1, 2, map);

			Assert.AreEqual(336, result);
		}

		[TestMethod]
		public void Problem1()
		{
			Assert.AreEqual(286, Day3.Problem1());
		}

		[TestMethod]
		public void Problem2()
		{
			Assert.AreEqual(3638606400, Day3.Problem2());
		}
	}


}
