using System;

namespace _05_Array
{
	class Program
	{
		static void Main(string[] args)
		{
			// Declarate a single array
			int[] arrayNumber1 = new int[3];

			arrayNumber1[0] = 1;
			arrayNumber1[1] = 2;
			arrayNumber1[2] = 3;

			foreach (int number in arrayNumber1)
			{
				Console.WriteLine(number);
			}

			// Declare and set simple array
			string[] arrayNames = new string[] { "Paola", "Ana", "Juan" };

			foreach (string name in arrayNames)
			{
				Console.WriteLine(name);
			}

			// Declare and set simple array - Alternative syntax
			int[] arrayNumber2 = { 5, 6, 7, 8, 9 };

			foreach (int number in arrayNumber2)
			{
				Console.WriteLine(number);
			}

			// Declare a two dimensional array
			string[,] arrayDoubleString = new string[3, 2];

			arrayDoubleString[0, 0] = "Array 0, String 0";
			arrayDoubleString[0, 1] = "Array 0, String 1";
			arrayDoubleString[1, 0] = "Array 1, String 0";
			arrayDoubleString[1, 1] = "Array 1, String 1";
			arrayDoubleString[2, 0] = "Array 2, String 0";
			arrayDoubleString[2, 1] = "Array 2, String 1";

			foreach (string name in arrayDoubleString)
			{
				Console.WriteLine(name);
			}

			// Declare and set two dimensional array
			int[,] arrayNumber3 = { { 0, 1, 2 }, { 3, 4, 5 } };

			foreach (int number in arrayNumber3)
			{
				Console.WriteLine(number);
			}

			// Matrix of matrices
			int[][] arrayComp = new int[3][];

			arrayComp[0] = new int[2] { 0, 1 };
			arrayComp[1] = new int[3] { 2, 3, 4 };
			arrayComp[2] = new int[4] { 5, 6, 7, 8 };

			foreach (int number in arrayComp[1])
			{ 
				Console.WriteLine(number);
			}
		}
	}
}
