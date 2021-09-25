# Basic Operations
In this part we are going to see the different basic operations that exist in C #. These operations include mathematical operations between different types of variables.

```c#
int number1 = 24;
int number2 = 98;
```

## Postfix increment operator

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

## Prefix increment operator

Execution (number++) adds 1 to the "number". This execution returns "number + 1" before completion of the call.

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
