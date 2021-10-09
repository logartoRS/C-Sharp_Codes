using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Inheritance
{
	class Plant:Species
	{
		// Properties
		private String color;
		private int size;
		private bool hasFruit;

		// Gets and Sets
		public String Color
		{
			get { return color; }
			set { color = value; }
		}
		public int Size
		{
			get { return size; }
			set { size = value; }
		}
		public bool HasFruit
		{
			get { return hasFruit; }
			set { hasFruit = value; }
		}

		// Default constructor
		public Plant() { }

		// Parameterized constructor
		public Plant(String name, String scientificName, String color, int size, bool hasFruit) : base(name, scientificName)
		{
			this.color = color;
			this.size = size;
			this.hasFruit = hasFruit;
		}

		// Methods
		public void mention()
		{
			Console.WriteLine("Name: {0}", Name);
			Console.WriteLine("Scientific name: {0}", ScientificName);
			Console.WriteLine("Color: {0}", this.color);
			Console.WriteLine("Average size: {0}", this.size);
			Console.WriteLine("Has Fruit: {0}", this.hasFruit);
		}
	}
}
