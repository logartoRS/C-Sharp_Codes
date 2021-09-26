using System;

namespace _03_Conditional_logic_and_loop_statements
{
	class Program
	{
		static void Main(string[] args)
		{
			int number1 = 98;
			int number2 = 24;
			int number3 = 8;

			// IF statement
			if (number1 > number2)
			{
				Console.WriteLine("Number 1 is greater than number 2");
			}

			// IF - ELSE statement
			if (number1 < number2)
			{
				Console.WriteLine("Number 1 is leen than number 2");
			}
			else
			{
				Console.WriteLine("Number 1 is greater than Number 2");
			}

			// ELSE IF statement
			if (number1 < number2)
			{
				Console.WriteLine("Number 1 is leen than number 2");
			}
			else if (number1 < number3)
			{
				Console.WriteLine("Number 1 is leen than number 3");
			}
			else
			{
				Console.WriteLine("Number 1 is greater than Number 2 and Number 3");
			}

			// SWITCH statement
			switch(number1)
			{
				case 8:
					Console.WriteLine("The number is 8");
					break;
				case 24:
					Console.WriteLine("The number is 24");
					break;
				case 98:
					Console.WriteLine("The number is 24");
					break;
				default:
					Console.WriteLine("The number is not here");
					break;
			}

			// WHILE statement
			while (number3 < number2)
			{
				Console.WriteLine(number3);
				number3++;
			}

			// DO WHILE statement
			number3 = 8;
			do
			{
				Console.WriteLine(number3);
				number3++;
			} while (number3 > number2);

			number3 = 8;
			do
			{
				Console.WriteLine(number3);
				number3++;
			} while (number3 < number2);

			// FOR statements
			number3 = 8;
			for (int i = 0; i <= number3; i++)
			{
				Console.WriteLine("Numero: " + i.ToString());
			}
		}
	}
}
