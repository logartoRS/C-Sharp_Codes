using System;

namespace _08_Interface
{
	class Program
	{
		static void Main(string[] args)
		{
			student juan = new student("Juan", "Salazar", "SKN School", new DateTime(1998, 8, 24));

			juan.presentation();
			juan.document();
			Console.WriteLine("Age of Juan: {0}", juan.calculateAge());

			Console.ReadLine();
		}
	}
}
