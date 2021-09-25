# Basic Operations
In this part we are going to see the different basic operations that exist in C #. These operations include mathematical operations between different types of variables.

```c#
int number1 = 24;
int number2 = 98;
```

### Postfix increment operator (++number)

Execution (++number) adds 1 to the "number". This execution returns "number + 1" after completion of the call.

```c#
Console.WriteLine("Postfix increment operator (i++):");
Console.WriteLine(number1);
Console.WriteLine(number1++);
Console.WriteLine(number1);
```

**Result:**

> Postfix increment operator (i++):
> 
> 24
> 
> 24
> 
> 25

### Prefix increment operator (number++)

Execution (number++) adds 1 to the "number". This execution returns "number + 1" after completion of the call.

```c#
Console.WriteLine("Prefix increment operator (++i):");
Console.WriteLine(number1);
Console.WriteLine(++number1);
Console.WriteLine(number1);
```

**Result:**

> Prefix increment operator (++i):
> 
> 24
> 
> 25
> 
> 25

### Postfix decrement operator (number--)

Execution (number--) subtracts 1 from "number". This execution returns "number - 1" before completion of the call.

```c#
Console.WriteLine("\nPostfix decrement operator (i--):");
Console.WriteLine(number1);
Console.WriteLine(number1--);
Console.WriteLine(number1);
```

**Result:**

> Postfix decrement operator (i--):
> 
> 24
> 
> 24
> 
> 23

### Prefix decrement operator (--number)

Execution (--number) subtracts 1 from "number". This execution returns "number - 1" after completion of the call.

```c#
Console.WriteLine("\nPrefix decrement operator (--i):");
Console.WriteLine(number1);
Console.WriteLine(--number1);
Console.WriteLine(number1);
```

**Result:**

> Prefix decrement operator (--i):
> 
> 24
> 
> 23
> 
> 23

### Addition operator [(number1 + number2) or (number1 += number2 -> number1 = number1 + number2)]

```c#
Console.WriteLine("\nAddition operator (+):");
Console.WriteLine(number1 + number2);
Console.WriteLine(number1 += number2);
```

**Result:**

> Addition operator (+):
> 122
> 122

### Subtraction operator [(number1 - number2) or (number1 -= number2 -> number1 = number1 - number2)]

```c#
Console.WriteLine("\nSubtraction operator (-):");
Console.WriteLine(number1 - number2);
Console.WriteLine(number1 -= number2);
```

**Result:**

> Subtraction operator (-):
> 
> -74
> 
> -74

### Multiplication operator (number1 * number2)

```c#
Console.WriteLine("\nMultiplication operator (*):");
Console.WriteLine(number1 * number2);
```

**Result:**

> Multiplication operator (*):
> 2352

### Division operator (number1 / number2)

The result is the quotient of the division between "number1" and "number2". With this operator we have to be careful with the type of dividend data.

```c#
Console.WriteLine("\nDivision operator (/):");
Console.WriteLine((float)number1 / number2);
Console.WriteLine((double)number1 / number2);
Console.WriteLine((decimal)number1 / number2);
```

**Result:**

> Division operator (/):
> 
> 0.24489796
> 
> 0.24489795918367346
> 
> 0.244897959183673469387755102

### Remainder operator (number1 % number2)

The result is the residue of the division between "number1" and "number2".

```c#
Console.WriteLine("\nRemainder operator (%):");
Console.WriteLine(number1 % number2);
Console.WriteLine(number2 % number1);
```

**Result:**

> Remainder operator (%):
> 
> 24
> 
> 2

## Notes

### Parsing

Is used to convert a string to a number.

> int vumber = Int32.Parse(String)
> 
> Example: number1 = Int32.Parse("5") -> number1 = 5
