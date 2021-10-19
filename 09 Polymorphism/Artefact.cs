using System;
using System.Collections.Generic;
using System.Text;

namespace _09_Polymorphism
{
	class Artefact
	{
		// Properties
		public int Measure { get; set; }
		public int Weight { get; set; }
		public int Volttage { get; set; }
		public String Warranty { get; set; }

		// Constructor
		public Artefact(int measure, int weight, int volttage, String warranty)
		{
			this.Measure = measure;
			this.Weight = weight;
			this.Volttage = volttage;
			this.Warranty = warranty;
		}

		// Methods
		public virtual void showData()
		{
			Console.WriteLine("Measure: {0}", Measure);
			Console.WriteLine("Weight: {0}", Weight);
			Console.WriteLine("Volttage: {0}", Volttage);
			Console.WriteLine("Warranty: {0}", Warranty);
		}

		public void showCompany()
		{
			Console.WriteLine("This company has no company.");
		}
	}
}
