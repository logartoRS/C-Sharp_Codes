using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Inheritance
{
	class Species
	{
		// Properties
		private String name;
		private String scientificName;

		// Gets and Sets
		public String Name
		{
			get	{ return name; }
			set	{ name = value; }
		}
		public String ScientificName
		{
			get { return scientificName; }
			set	{ scientificName = value; }
		}

		// Default constructor
		public Species()
		{
			this.name = "";
			this.scientificName = "";
		}

		// Parameterized constructor
		public Species(String name, String scientificName)
		{
			this.name = name;
			this.scientificName = scientificName;
		}

		// Methods
		public void mention()
		{
			Console.WriteLine("Name: {0}", this.name);
			Console.WriteLine("Scientific name: {0}", this.scientificName);
		}
	}
}
