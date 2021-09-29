using System;

namespace _04_Metodos
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteHelloWorld();

			Console.WriteLine(stringHelloWorld());

			Console.WriteLine(returnNumber());

			Console.WriteLine(returnSum(5, 10));

			Console.WriteLine(andCondition(true, false));
			
			boiedMethod();

			Console.ReadLine();
		}

		static void WriteHelloWorld()
		{
			Console.WriteLine("Hello World");
		}

		static string stringHelloWorld()
		{
			return "Hello World";
		}

		static int returnNumber()
		{
			int number = 10;

			return number;
		}

		static int returnSum(int x, int y)
		{
			int number;

			number = x + y;

			return number;
		}

		static bool andCondition(bool x, bool y)
		{
			return (x & y);
		}

		// Expression Bodied Methods
		static void boiedMethod() => Console.WriteLine("This is a Bodied Method");

	}
}
