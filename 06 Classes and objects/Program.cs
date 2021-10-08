using System;

namespace _06_Classes_and_objects
{
	class Program
	{
		static void Main(string[] args)
		{
			// Use of the class through an object
			Animal koala = new Animal();

			// Use the Set
			koala.Name = "Koala";
			koala.ScientificName = "Phascolarctos cinereus";
			koala.Size = 70;
			koala.Weight = 15;

			// Use the constructors
			Animal dog = new Animal();
			Animal cat = new Animal("Cat", "Felis catus", 40, 4);

			// Use the Get
			Console.WriteLine(dog.Name);
			Console.WriteLine(dog.ScientificName);
			Console.WriteLine(cat.Name);
			Console.WriteLine(cat.ScientificName);
			Console.WriteLine(koala.Name);
			Console.WriteLine(koala.ScientificName);

			// Use the methods
			dog.description();
			cat.description();
			koala.description();

			Console.ReadLine();
		}
	}
}
