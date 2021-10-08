using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Classes_and_objects
{
	class Animal
	{
		// Properties
		private String name;
		private String scientificName;
		private int size;
		private int weight;

		// Gets and Sets
		public String Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
		public String ScientificName
		{
			get
			{
				return scientificName;
			}
			set
			{
				scientificName = value;
			}
		}
		public int Size
		{
			get
			{
				return size;
			}
			set
			{
				size = value;
			}
		}
		public int Weight
		{
			get
			{
				return weight;
			}
			set
			{
				weight = value;
			}
		}

		// Default constructor
		public Animal()
		{
			this.name = "Dog";
			this.scientificName = "Canis familiaris";
			this.size = 50;
			this.weight = 20;
		}

		// Parameterized constructor
		public Animal(String name, String scientificName, int size, int weight)
		{
			this.name = name;
			this.scientificName = scientificName;
			this.size = size;
			this.weight = weight;
		}

		// Methods
		public void description()
		{
			Console.WriteLine("Name: {0}", this.name);
			Console.WriteLine("Scientific name: {0}", this.scientificName);
			Console.WriteLine("Average size: {0} cm", this.size);
			Console.WriteLine("Average weight: {0} Kg", this.weight);
		}
	}
}
