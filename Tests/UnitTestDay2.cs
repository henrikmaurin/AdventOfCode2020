using AdventOfCode2020.Days;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests
{
	[TestClass]
	public class UnitTestDay2
	{
		[TestMethod]
		public void Example1()
		{
			string password = "1-3 a: abcde";
			bool result = Day2.ValidatePassword(password);

			Assert.IsTrue(result);
		}

		[TestMethod]
		public void Example2()
		{
			string password = "1-3 b: cdefg";
			bool result = Day2.ValidatePassword(password);

			Assert.IsFalse(result);
		}

		[TestMethod]
		public void Count()
		{
			List<string> passwords = new List<string>
				{
					"1-3 a: abcde",
					"1-3 b: cdefg",
					"2-9 c: ccccccccc"
				};

			int result = Day2.ValidatePasswords(passwords);
			Assert.AreEqual(2, result);
		}


		[TestMethod]
		public void Example21()
		{
			string password = "1-3 a: abcde";
			bool result = Day2.ValidatePasswordNew(password);

			Assert.IsTrue(result);
		}

		[TestMethod]
		public void Example22()
		{
			string password = "1-3 b: cdefg";
			bool result = Day2.ValidatePasswordNew(password);

			Assert.IsFalse(result);
		}

		[TestMethod]
		public void Example23()
		{
			string password = "2-9 c: ccccccccc";
			bool result = Day2.ValidatePasswordNew(password);

			Assert.IsFalse(result);
		}

		[TestMethod]
		public void Count2()
		{
			List<string> passwords = new List<string>
				{
					"1-3 a: abcde",
					"1-3 b: cdefg",
					"2-9 c: ccccccccc"
				};

			int result = Day2.ValidatePasswordsNew(passwords);
			Assert.AreEqual(1, result);
		}

		[TestMethod]
		public void Problem1()
		{
			Assert.AreEqual(625, Day2.Problem1());
		}

		[TestMethod]
		public void Problem2()
		{
			Assert.AreEqual(391, Day2.Problem2());
		}
	}
}
