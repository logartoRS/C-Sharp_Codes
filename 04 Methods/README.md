# Methods

Methods are an important part in C # because they contain code that we can use at any time by calling the main part. Methods are important because they have the ability to replace lines of code or similar lines of code based on variants. Making the code look cleaner and more orderly. Typically, the methods are declared at the end of the code.

## Syntax of a method in C#

```c#
typeReturn nameMethod (ParameterList or nothing)
{
   Statements to be executed
}
```

### Void Method

This method does not require any returns on this line of codes. When we call the void method we only execute the code in the main part.

**Method:**

```c#
static void WriteHelloWorld()
{
   Console.WriteLine("Hello World");
}   
```

**Call:**

```c#
WriteHelloWorld();
```

**Result:**

> Hello World

### Methods with returns

Estos métodos requieren una línea principal en su código, necesitan declarar * return * y una variable o constante que tenga el mismo tipo de variable que el método.

**Method:**

```c#
static string stringHelloWorld()
{
   return "Hello World";
}
```

**Call:**

```c#
Console.WriteLine(stringHelloWorld());
```

**Result:**

> Hello World

**Method:**

```c#
static int returnNumber()
{
   int number = 10;

   return number;
}
```

**Call:**

```c#
Console.WriteLine(returnNumber());
```

**Result:**

> 10

### Method with variables

It is like the other methods but when you call the method we can add variables that the methods can use to execute their code.

**Method:**

```c#
static int returnSum(int x, int y)
{
   int number;

   number = x + y;

   return number;
}
```

**Call:**

```c#
Console.WriteLine(returnSum(5, 10));
```

**Result:**

> 15

**Method:**

```c#
static bool andCondition(bool x, bool y)
{
   return (x & y);
}
```

**Call:**

```c#
Console.WriteLine(andCondition(true, false));
```

**Result:**

> False

### Expression Bodied Methods

It is a simplified use of writing a method, generally for use with methods that have one line.

**Method:**

```c#
static void boiedMethod() => Console.WriteLine("This is a Bodied Method");
```

**Call:**

```c#
boiedMethod();
```

**Result:**

> This is a Bodied Method

## Notes

### Access Modifiers

We use the methods that start with the word *static*, *static* is an access modifier that allows us to use the method in the main part of the code because it is also *static*. But it is not the only access modifier, in C # we have different types and they are:

- **Public:** the code can be accessed by any other code in the same program or assembly that references it.
- **Internal:** the code can be accessed through any other code in the same program, but not from another assembly.
- **Private:** the code can only be accessed through a code of the same class.
- **Protected:** The code can be accessed only by code in the same class, or in another class that inherits from the parent class.
