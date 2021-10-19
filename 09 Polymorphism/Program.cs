using System;
using System.Collections.Generic;

namespace _09_Polymorphism
{
	class Program
	{
		static void Main(string[] args)
		{
			var artefatcs = new List<Artefact>
			{
				new Artefact(150, 75, 110, "3 years"),
				new Microwave(75, 15, 220, "2 years", "Microwave SAC", "SKN 145")
			};

			foreach(var artefact in artefatcs)
			{
				artefact.showData();
				artefact.showCompany();
				Console.Write("\n");
			}

			Microwave microwave1 = new Microwave(75, 15, 220, "2 years", "OGTA", "OGT 187");
			microwave1.showData();
			microwave1.showCompany();
			Console.Write("\n");

			Console.ReadLine();
		}
	}
}
