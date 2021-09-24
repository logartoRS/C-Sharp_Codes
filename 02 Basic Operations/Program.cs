using System;

namespace _02_Basic_Operations
{
	class Program
	{
		static void Main(string[] args)
		{
			int number1;
			int number2;

			// Postfix increment operator
			number1 = 24;
			Console.WriteLine("Postfix increment operator (i++):");
			Console.WriteLine(number1);
			Console.WriteLine(number1++);
			Console.WriteLine(number1);

			// Prefix increment operator
			number1 = 24;
			Console.WriteLine("\nPrefix increment operator (++i):");
			Console.WriteLine(number1);
			Console.WriteLine(++number1);
			Console.WriteLine(number1);

			// Postfix decrement operator
			number1 = 24;
			Console.WriteLine("\nPostfix decrement operator (i--):");
			Console.WriteLine(number1);
			Console.WriteLine(number1--);
			Console.WriteLine(number1);

			// Prefix decrement operator
			number1 = 24;
			Console.WriteLine("\nPrefix decrement operator (--i):");
			Console.WriteLine(number1);
			Console.WriteLine(--number1);
			Console.WriteLine(number1);

			// Addition operator (+)
			number1 = 24;
			number2 = 98;
			Console.WriteLine("\nAddition operator (+):");
			Console.WriteLine(number1 + number2);
			Console.WriteLine(number1 += number2);

			// Subtraction operator (-)
			number1 = 24;
			number2 = 98;
			Console.WriteLine("\nSubtraction operator (-):");
			Console.WriteLine(number1 - number2);
			Console.WriteLine(number1 -= number2);

			// Multiplication operator (*)
			number1 = 24;
			number2 = 98;
			Console.WriteLine("\nMultiplication operator (*):");
			Console.WriteLine(number1 * number2);

			// Division operator (/)
			number1 = 24;
			number2 = 98;
			Console.WriteLine("\nDivision operator (/):");
			Console.WriteLine((float)number1 / number2);
			Console.WriteLine((double)number1 / number2);
			Console.WriteLine((decimal)number1 / number2);

			// Remainder operator (%)
			number1 = 24;
			number2 = 98;
			Console.WriteLine("\nRemainder operator (%):");
			Console.WriteLine(number1 % number2);
			Console.WriteLine(number2 % number1);

			Console.ReadLine();
		}
	}
}
