using System;

namespace _07_Inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			Animal dog = new Animal("Dog", "Canis familiaris", 50, 20);
			Plant appleTree = new Plant("Apple Tree", "Malus domestica", "Green", 10, true);

			dog.mention();
			appleTree.mention();

			Console.ReadLine();
		}
	}
}
