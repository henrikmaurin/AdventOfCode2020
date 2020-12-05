using AdventOfCode2020.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2020.Days
{
	public class Day4
	{
		private static List<string> validColors = new List<string> { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };
		public static int Problem1()
		{
			List<string> passportData = File.ReadAllLines("Data/Day4.txt").ToList();
			List<Passport> passports = Parse(passportData);

			int result = ValidPassports(passports);
			Console.WriteLine(result);
			return result;
		}

		public static int Problem2()
		{
			List<string> passportData = File.ReadAllLines("Data/Day4.txt").ToList();
			List<Passport> passports = Parse(passportData);

			int result = ValidPassports(passports,true);
			Console.WriteLine(result);
			return result;
		}


		public static int ValidPassports(List<Passport> passports, bool higherSecurity = false)
		{
			return passports.Where(p => Validate(p, higherSecurity)).Count();
		}


		public static bool Validate(Passport passport, bool higherSecurity = false)
		{
			if (passport.BirthYear == null)
				return false;
			if (higherSecurity && passport.BirthYear < 1920)
				return false;
			if (higherSecurity && passport.BirthYear > 2002)
				return false;

			if (passport.IssueYear == null)
				return false;
			if (higherSecurity && passport.IssueYear < 2010)
				return false;
			if (higherSecurity && passport.IssueYear > 2020)
				return false;

			if (passport.ExpirationYear == null)
				return false;
			if (higherSecurity && passport.ExpirationYear < 2020)
				return false;
			if (higherSecurity && passport.ExpirationYear > 2030)
				return false;

			if (passport.Height == null)
				return false;
			if (higherSecurity)
			{
				if (passport.Height.EndsWith("cm"))
				{
					if (passport.Height.Replace("cm", "").ToInt() < 150)
						return false;
					if (passport.Height.Replace("cm", "").ToInt() > 193)
						return false;
				}
				else if (passport.Height.EndsWith("in"))
				{
					if (passport.Height.Replace("in", "").ToInt() < 59)
						return false;
					if (passport.Height.Replace("in", "").ToInt() > 76)
						return false;
				}
				else
					return false;
			}

			if (passport.HairColor == null)
				return false;
			if (higherSecurity && !Regex.IsMatch(passport.HairColor, "^#(?:[0-9a-fA-F]{3}){1,2}$"))
				return false;


			if (passport.EyeColor == null)
				return false;
			if (higherSecurity && !validColors.Contains(passport.EyeColor))
				return false;

			if (passport.PassportId == null)
				return false;
			if (higherSecurity && !Regex.IsMatch(passport.PassportId, "^(?:[0-9]{9})$"))
				return false;

			return true;
		}



		public static List<Passport> Parse(List<string> passportData)
		{
			List<string> joined = new List<string>();
			string temp = string.Empty;

			foreach (string line in passportData)
			{
				if (string.IsNullOrWhiteSpace(line))
				{
					joined.Add(temp.Trim());
					temp = string.Empty;
				}
				else
					temp += line + " ";
			}

			if (!string.IsNullOrEmpty(temp))
				joined.Add(temp.Trim());

			return joined.Select(p => Parse(p)).ToList();
		}

		public static Passport Parse(string passportData)
		{
			List<string> props = passportData.Split(" ").ToList();
			Passport retPassport = new Passport();

			foreach (string prop in props)
			{
				string p = prop.Split(":").First();
				string d = prop.Split(":").ElementAt(1);
				switch (p)
				{
					case "byr":
						retPassport.BirthYear = d.ToInt();
						break;
					case "iyr":
						retPassport.IssueYear = d.ToInt();
						break;
					case "eyr":
						retPassport.ExpirationYear = d.ToInt();
						break;
					case "hgt":
						retPassport.Height = d;
						break;
					case "hcl":
						retPassport.HairColor = d;
						break;
					case "ecl":
						retPassport.EyeColor = d;
						break;
					case "pid":
						retPassport.PassportId = d;
						break;
					case "cid":
						retPassport.CountryId = d.ToInt();
						break;
				}
			}
			return retPassport;
		}

		public class Passport
		{
			public int? BirthYear { get; set; }
			public int? IssueYear { get; set; }
			public int? ExpirationYear { get; set; }
			public string Height { get; set; }
			public string HairColor { get; set; }
			public string EyeColor { get; set; }
			public string PassportId { get; set; }
			public int? CountryId { get; set; }
		}
	}
}
