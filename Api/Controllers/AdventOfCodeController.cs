using AdventOfCode2020.Common;
using AdventOfCode2020.Days;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Api.Controllers
{
	[ApiController]
	[Route("2020")]
	public class AdventOfCodeController : ControllerBase
	{
		[HttpGet]
		public int D1([FromRoute]string problem, [FromBody] string data)
		{
			Day1 day1 = new Day1();

			List<int> values = data.SplitOnNewline().Select(v => int.Parse(v)).ToList();
			int goalValue = 2020;

			int result = Day1.FindAndMultiplyX(values, goalValue, 2);

			return result;
		}

	}
}
