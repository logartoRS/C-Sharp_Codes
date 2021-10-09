using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Inheritance
{
	class Animal:Species
	{
		// Properties
		private int size;
		private int weight;

		// Gets and Sets
		public int Size
		{
			get { return size; }
			set { size = value; }
		}
		public int Weight
		{
			get { return weight; }
			set { weight = value; }
		}

		// Default constructor
		public Animal() { }

		// Parameterized constructor
		public Animal(String name, String scientificName, int size, int weight):base(name, scientificName)
		{
			this.size = size;
			this.weight = weight;
		}

		// Methods
		public void mention()
		{
			Console.WriteLine("Name: {0}", Name);
			Console.WriteLine("Scientific name: {0}", ScientificName);
			Console.WriteLine("Average size: {0}", this.size);
			Console.WriteLine("Average weight: {0}", this.weight);
		}
	}
}
