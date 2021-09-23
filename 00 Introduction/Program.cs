using System;

namespace _00_Introduction
{
	class Program
	{
		static void Main(string[] args)
		{
			// Numerical variables
			byte byteNumber1 = 0;
			byte byteNumber2 = 255;

			sbyte sbyteNumber1 = -128;
			sbyte sbyteNumber2 = 127;

			int intNumber1 = -2147483648;
			int intNumber2 = 2147483647;

			uint uintNumber1 = 0;
			uint uintNumber2 = 4294967295;

			short shortNumber1 = -32767;
			short shortNumber2 = 32767;

			ushort ushortNumber1 = 0;
			ushort ushortNumber2 = 65535;

			long longNumber1 = -922337203685477508;
			long longNumber2 = 922337203685477507;

			ulong ulongNumber1 = 0;
			ulong ulongNumber2 = 18446744073709551615;

			float floatNumber1 = -3.402823f;
			float floatNumber2 = 3.402823f;

			double doubleNumber1 = -1.79769313486232;
			double doubleNumber2 = 1.79769313486232;

			decimal decimalNumber1 = -5.23456897M;
			decimal decimalNumber2 = 5.23456897M;

			// Unicode characters
			char charCharacter1 = 'A';
			char charCharacter2 = 'G';

			// Boolean variable
			bool boolCharacter1 = false;
			bool boolCharacter2 = true;

			// Variable object
			object objectCharacter1 = "A";
			object objectCharacter2 = 24;
			object objectCharacter3 = true;

			// Variable string
			string stringText1 = "Character1";
			string stringText2 = "Character2";

			// Variables printing
			Console.WriteLine("Numerical variables:");
			Console.WriteLine("Byte Number 1: " + byteNumber1.ToString());
			Console.WriteLine("Byte Number 2: " + byteNumber2.ToString());
			Console.WriteLine("Sbyte Number 1: " + sbyteNumber1.ToString());
			Console.WriteLine("Sbyte Number 2: " + sbyteNumber2.ToString());
			Console.WriteLine("Int Number 1: " + intNumber1.ToString());
			Console.WriteLine("Int Number 2: " + intNumber2.ToString());
			Console.WriteLine("Uint Number 1: " + uintNumber1.ToString());
			Console.WriteLine("Uint Number 2: " + uintNumber2.ToString());
			Console.WriteLine("Short Number 1: " + shortNumber1.ToString());
			Console.WriteLine("Short Number 2: " + shortNumber2.ToString());
			Console.WriteLine("Ushort Number 1: " + ushortNumber1.ToString());
			Console.WriteLine("Ushort Number 2: " + ushortNumber2.ToString());
			Console.WriteLine("Long Number 1: " + longNumber1.ToString());
			Console.WriteLine("Long Number 2: " + longNumber2.ToString());
			Console.WriteLine("Ulong Number 1: " + ulongNumber1.ToString());
			Console.WriteLine("Ulong Number 2: " + ulongNumber2.ToString());
			Console.WriteLine("Float Number 1: " + floatNumber1.ToString());
			Console.WriteLine("Float Number 2: " + floatNumber2.ToString());
			Console.WriteLine("Double Number 1: " + doubleNumber1.ToString());
			Console.WriteLine("Double Number 2: " + doubleNumber2.ToString());
			Console.WriteLine("Decimal Number 1: " + decimalNumber1.ToString());
			Console.WriteLine("Decimal Number 2: " + decimalNumber2.ToString());

			Console.WriteLine("\nChar variables:");
			Console.WriteLine("Char 1: " + charCharacter1.ToString());
			Console.WriteLine("Char 2: " + charCharacter2.ToString());

			Console.WriteLine("\nBoolean variables:");
			Console.WriteLine("Bool 1: " + boolCharacter1.ToString());
			Console.WriteLine("Bool 2: " + boolCharacter2.ToString());
			
			Console.WriteLine("\nVariable Objects:");
			Console.WriteLine("Object 1: " + objectCharacter1.ToString());
			Console.WriteLine("Object 2: " + objectCharacter2.ToString());
			Console.WriteLine("Object 3: " + objectCharacter3.ToString());

			Console.WriteLine("\nVariable strings:");
			Console.WriteLine("String 1: " + stringText1.ToString());
			Console.WriteLine("String 2: " + stringText2.ToString());

			Console.ReadLine();
		}
	}
}
