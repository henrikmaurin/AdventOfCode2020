using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020.Common
{
	public static class StringHelpers
	{
		public static int ToInt(this string s)
		{
			int.TryParse(s, out int outVal);
			return outVal;
		}

		public static long ToLong(this string s)
		{
			long.TryParse(s, out long outVal);
			return outVal;
		}

		public static List<string> JoinMultiline(this List<string> data, string joinchar)
		{
			StringBuilder builder = new StringBuilder();
			List<string> strings = new List<string>();
			foreach (string current in data)
			{
				if (!string.IsNullOrWhiteSpace(current))
					builder.Append(joinchar + current);
				else
				{
					strings.Add(builder.ToString().Trim());
					builder.Clear();
				}
			}
			if (builder.Length > 0)
				strings.Add(builder.ToString().Trim());

			return strings;
		}
	}
}
