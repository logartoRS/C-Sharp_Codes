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
