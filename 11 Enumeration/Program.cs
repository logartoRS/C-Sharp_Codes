using System;
using System.Collections.Generic;

namespace _11_Enumeration
{
	class Program
	{
		enum Season
		{
			Spring,
			Summer,
			Autumn,
			Winter
		}

		enum Day
		{
			Mo = 2,
			Tu,
			We,
			Th,
			Fr = 13,
			Sa,
			Su
		}

		static void Main(string[] args)
		{
			Season spring = Season.Spring;
			Day monday = Day.Mo;

			Season[] seasons = new Season[4] { Season.Spring, Season.Summer, Season.Autumn, Season.Winter };
			Day[] days = new Day[7] { Day.Mo, Day.Tu, Day.We, Day.Th, Day.Fr, Day.Sa, Day.Su };

			Console.WriteLine(spring);
			Console.WriteLine((int)spring);

			Console.WriteLine(monday);
			Console.WriteLine((int)monday);

			foreach (Season season in seasons)
			{
				Console.WriteLine(season);
				Console.WriteLine((int)season);
			}

			foreach(Day day in days)
			{
				Console.WriteLine(day);
				Console.WriteLine((int)day);
			}

			Console.ReadLine();
		}
	}
}
