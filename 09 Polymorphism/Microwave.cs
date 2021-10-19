using System;
using System.Collections.Generic;
using System.Text;

namespace _09_Polymorphism
{
	sealed class Microwave : Artefact
	{
		// Properties
		public String Company { get; set; }
		public String Model { get; set; }

		// Constructor
		public Microwave(int measure, int weight, int volttage, String warranty, String company, String model):base(measure, weight, volttage, warranty)
		{
			this.Company = company;
			this.Model = model;
		}

		// Methods
		public override void showData()
		{
			Console.WriteLine("Measure: {0}", Measure);
			Console.WriteLine("Weight: {0}", Weight);
			Console.WriteLine("Volttage: {0}", Volttage);
			Console.WriteLine("Warranty: {0}", Warranty);
			Console.WriteLine("Company: {0}", Company);
			Console.WriteLine("Model: {0}", Model);
		}

		public new void showCompany()
		{
			Console.WriteLine("The microwane's company is {0}.", Company);
		}

	}

}
