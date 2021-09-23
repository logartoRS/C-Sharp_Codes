# Introduction
In this part we will see the different types of variables that are supported in base C #.

**Variable:** In simplified form, variables are names that represent spaces in memory, we can use these variables by referring to their names, and depending on the type of variable this space in memory can be larger or smaller.

## Types of variable

* **Byte:** Is a unsigned integer, Byte is in the range 0 to 255.

  ```c#
  byte byteNumber1 = 0;
  byte byteNumber2 = 255;
  ```

  That we can print on the console to see the numbers.

  ```c#
  Console.WriteLine("Byte Number 1: " + byteNumber1.ToString());
  Console.WriteLine("Byte Number 2: " + byteNumber2.ToString());
  ```
  
  Result:
  
  > Byte Number 1: 0
  > 
  > Byte Number 2: 255

* **Sbyte:** Is a signed integer, Byte is in the range -128 to 127.

  ```c#
  sbyte sbyteNumber1 = -128;
  sbyte sbyteNumber2 = 127;
  ```

  That we can print on the console to see the numbers.

  ```c#
  Console.WriteLine("Sbyte Number 1: " + sbyteNumber1.ToString());
  Console.WriteLine("Sbyte Number 2: " + sbyteNumber2.ToString());
  ```
  
  Result:
  
  > Sbyte Number 1: -128
  > 
  > Sbyte Number 2: 127

* **Int:** Is a signed integer, Byte is in the range -2 147 483 648 to 2 147 483 647.

  ```c#
  int intNumber1 = -2147483648;
  int intNumber2 = 2147483647;
  ```

  That we can print on the console to see the numbers.

  ```c#
  Console.WriteLine("Int Number 1: " + intNumber1.ToString());
  Console.WriteLine("Int Number 2: " + intNumber2.ToString());
  ```
  
  Result:
  
  > Int Number 1: -2147483648
  > 
  > Int Number 2: 2147483647
