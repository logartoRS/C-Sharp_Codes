# Conditional logic and loop statements

In this part we are going to talk about conditional logic statements to decide what code to execute; and the loop statements to repeat the execution of the code a number of times.

```c#
int number1 = 98;
int number2 = 24;
int number3 = 8;
```

### IF statement

With this code we give the system a specific condition that if it is TRUE, it will execute a certain code.}

```c#
if (number1 > number2)
{
  Console.WriteLine("Number 1 is greater than number 2");
}
```

**Result:**

> Number 1 is greater than number 2

### IF - ELSE statement

It is the same idea of the IF statement, but in this case if the specific condition is FALSE, it will execute other code.

```c#
if (number1 < number2)
{
  Console.WriteLine("Number 1 is leen than number 2");
}
else
{
  Console.WriteLine("Number 1 is greater than Number 2");
}
```

**Result:**

> Number 1 is greater than Number 2

### ELSE IF statement

It is the same idea of the IF statement, but in this case there is the ELSE IF state that evaluates a different condition from the first IF statement and if this condition is TRUE, it executes its own code. ELSE IF statements can be placed one after the other.

```c#
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
```

**Result:**

> Number 1 is greater than Number 2 and Number 3

### SWITCH statement

It is a statement that when you give a piece of data, depending on the value of the data, the system executes a different code. If the value is not found in the different alternatives to choose from, the system executes a default code.

```c#
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
```

**Result:**

> The number is 24

### WHILE statement

It is a loop statement that executes a code many times until the condition is FALSE.

```c#
while (number3 < number2)
{
  Console.WriteLine(number3);
  number3++;
}
```

**Result:**

> 8
> 
> 9
> 
> 10
> 
> 11
> 
> 12
> 
> 13
> 
> 14
> 
> 15
> 
> 16
> 
> 17
> 
> 18
> 
> 19
> 
> 20
> 
> 21
> 
> 22
> 
> 23

