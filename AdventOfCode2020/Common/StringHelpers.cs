namespace AdventOfCode2020.Common
{
	public static class StringHelpers
	{
		public static int ToInt(this string s)
		{
			int.TryParse(s, out int outVal);
			return outVal;
		}
	}
}
