using AdventOfCode2020.Days;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests
{
	[TestClass]
	public class UnitTestDay1
	{
		[TestMethod]
		public void Example1()
		{
			int goalvalue = 2020;
			List<int> values = new List<int> { 1721,
									979,
									366,
									299,
									675,
									1456};

			int result = Day1.FindAndMultiply(values, goalvalue);

			Assert.AreEqual(514579, result);
		}

		[TestMethod]
		public void Example2()
		{
			int goalvalue = 2020;
			List<int> values = new List<int> { 1721,
									979,
									366,
									299,
									675,
									1456};

			int result = Day1.FindAndMultiply3(values, goalvalue);

			Assert.AreEqual(241861950, result);
		}

		[TestMethod]
		public void Problem1()
		{
			Assert.AreEqual(1018336, Day1.Problem1());
		}

		[TestMethod]
		public void Problem2()
		{
			Assert.AreEqual(288756720, Day1.Problem2());
		}

	}
}
