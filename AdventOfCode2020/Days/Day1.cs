using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2020.Days
{
	public class Day1
	{
		public static void Problem1()
		{
			List<int> values = File.ReadAllLines("Data/Day1.txt").Select(v => int.Parse(v)).ToList();
			int goalValue = 2020;

			int result = FindAndMultiply(values, goalValue);
			Console.WriteLine(result);
		}

		public static void Problem2()
		{
			List<int> values = File.ReadAllLines("Data/Day1.txt").Select(v => int.Parse(v)).ToList();
			int goalValue = 2020;

			int result = FindAndMultiply3(values, goalValue);
			Console.WriteLine(result);
		}



		public static int FindAndMultiply(List<int> values, int goalvalue)
		{
			for (int i = 0; i < (values.Count - 1); i++)
			{
				int value1 = values[i];
				for (int j = i + 1; j < values.Count; j++)
				{
					int value2 = values[j];
					if (value1 + value2 == goalvalue)
						return value1 * value2;
				}
			}
			return 0;
		}

		public static int FindAndMultiply3(List<int> values, int goalvalue)
		{
			for (int i = 0; i < (values.Count - 2); i++)
			{
				int value1 = values[i];
				for (int j = i + 1; j < (values.Count - 1); j++)
				{
					int value2 = values[j];
					for (int k = j + 1; k < values.Count; k++)
					{
						int value3 = values[k];

						if (value1 + value2 + value3 == goalvalue)
							return value1 * value2 * value3;
					}
				}
			}
			return 0;
		}
	}
}
