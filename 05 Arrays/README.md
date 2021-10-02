# Arrays

Is a structure that contains multiple variables of the same type. It is normally used if we want to require a group of variables that we can use iteratively. In other respects, each variable functions like a normal variable.

```c#
type[] arrayName1;
type[,] arrayName2;
type[][] arrayName3;
```

## Forms to declare and use

### Declarate a single array

We write the type of variable together with square brackets, we put the mane of the array on them and we do the initialization with the same type of variable with the size of the array.

```c#
int[] arrayNumber1 = new int[3];
```

**Initialization of variables in the array:**

```c#
arrayNumber1[0] = 1;
arrayNumber1[1] = 2;
arrayNumber1[2] = 3;
```

**Write in the console all the member in the array:**

```c#
foreach (int number in arrayNumber1)
{
  Console.WriteLine(number);
}
```

**Result:**

> 1
> 
> 2
> 
> 3

### Declare and set simple array

In this case we initialize the array with all the members.

```c#
string[] arrayNames = new string[] { "Paola", "Ana", "Juan" };
```

**Write in the console all the member in the array:**

```c#
foreach (string name in arrayNames)
{
  Console.WriteLine(name);
}
```

**Result:**

> Paola
> 
> Ana
> 
> Juan

### Declare and set simple array - Alternative syntax

Is the alternative case that  we initialize the array with all the members.

```c#
int[] arrayNumber2 = { 5, 6, 7, 8, 9 };
```

**Write in the console all the member in the array:**

```c#
foreach (int number in arrayNumber2)
{
  Console.WriteLine(number);
}
```

**Result:**

> 5
> 
> 6
> 
> 7
> 
> 8
> 
> 9

### Declare a two dimensional array

We can use the array in two dimentions to save more variables. We need to put the number of arrays in the main array, as well as the number of variables that each small array contains.

```c#
string[,] arrayDoubleString = new string[3, 2];
```

**Initialization of variables in the array:**

```c#
arrayDoubleString[0, 0] = "Array 0, String 0";
arrayDoubleString[0, 1] = "Array 0, String 1";
arrayDoubleString[1, 0] = "Array 1, String 0";
arrayDoubleString[1, 1] = "Array 1, String 1";
arrayDoubleString[2, 0] = "Array 2, String 0";
arrayDoubleString[2, 1] = "Array 2, String 1";
```

**Write in the console all the member in the array:**

```c#
foreach (string name in arrayDoubleString)
{
  Console.WriteLine(name);
}
```

**Result:**

> Array 0, String 0
> 
> Array 0, String 1
> 
> Array 1, String 0
> 
> Array 1, String 1
> 
> Array 2, String 0
>  
> Array 2, String 1

### Declare and set two dimensional array

We need to declare the type of variable and declare the variables in the same line.

```c#
int[,] arrayNumber3 = { { 0, 1, 2 }, { 3, 4, 5 } };
```

**Write in the console all the member in the array:**

```c#
foreach (int number in arrayNumber3)
{
  Console.WriteLine(number);
}
```

**Result:**

> 0
> 
> 1
> 
> 2
> 
> 3
> 
> 4
> 
> 5

### Matrix of matrices

Is another form to create an array of two order. But in this case the size of each array can be different.

```c#
int[][] arrayComp = new int[3][];
```

**Initialization of variables in the array:**

```c#
arrayComp[0] = new int[2] { 0, 1 };
arrayComp[1] = new int[3] { 2, 3, 4 };
arrayComp[2] = new int[4] { 5, 6, 7, 8 };
```

**Write in the console all the member in the array:**

```c#
foreach (int number in arrayComp[1])
{ 
  Console.WriteLine(number);
}
```

**Result:**

> 2
> 
> 3
> 
> 4

## Notes

### Foreach

It is a function that executes a code many times. The code runs as many times as if a variable existed in the array.

```c#
foreach (type nameVariable in arrayVariable)
{ 
  code;
}
```
