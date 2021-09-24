# Variables

In this part we will see the different types of variables that are supported in base C #. In simplified form, variables are names that represent spaces in memory, we can use these variables by referring to their names, and depending on the type of variable this space in memory can be larger or smaller.

## Types of variable

### Byte

Is a unsigned integer, *byte* is in the range 0 to 255.

```c#
byte byteNumber1 = 0;
byte byteNumber2 = 255;
```

That we can print on the console to see the numbers.

```c#
Console.WriteLine("Byte Number 1: " + byteNumber1.ToString());
Console.WriteLine("Byte Number 2: " + byteNumber2.ToString());
```
  
**Result:**
  
> Byte Number 1: 0
> 
> Byte Number 2: 255

### Sbyte

Is a signed integer, *sbyte* is in the range -128 to 127.

```c#
sbyte sbyteNumber1 = -128;
sbyte sbyteNumber2 = 127;
```

That we can print on the console to see the numbers.

```c#
Console.WriteLine("Sbyte Number 1: " + sbyteNumber1.ToString());
Console.WriteLine("Sbyte Number 2: " + sbyteNumber2.ToString());
```
  
**Result:**
  
> Sbyte Number 1: -128
> 
> Sbyte Number 2: 127

### Int

Is a signed integer, *int* is in the range -2147483648 to 2147483647.

```c#
int intNumber1 = -2147483648;
int intNumber2 = 2147483647;
```

That we can print on the console to see the numbers.

```c#
Console.WriteLine("Int Number 1: " + intNumber1.ToString());
Console.WriteLine("Int Number 2: " + intNumber2.ToString());
```
  
**Result:**
  
> Int Number 1: -2147483648
> 
> Int Number 2: 2147483647

### Uint

Is a unsigned integer, *uint* is in the range 0 to 4294967295.

```c#
uint uintNumber1 = 0;
uint uintNumber2 = 4294967295;
```

That we can print on the console to see the numbers.

```c#
Console.WriteLine("Uint Number 1: " + uintNumber1.ToString());
Console.WriteLine("Uint Number 2: " + uintNumber2.ToString());
```
  
**Result:**
  
> Uint Number 1: 0
> 
> Uint Number 2: 4294967295

### Short

Is a signed integer, *short* is in the range -32768 to 32767.

```c#
short shortNumber1 = -32767;
short shortNumber2 = 32767;
```

That we can print on the console to see the numbers.

```c#
Console.WriteLine("Short Number 1: " + shortNumber1.ToString());
Console.WriteLine("Short Number 2: " + shortNumber2.ToString());
```
  
**Result:**
  
> Short Number 1: -32767
> 
> Short Number 2: 32767

### Ushort

Is a unsigned integer, *ushort* is in the range 0 to 65535.

```c#
ushort ushortNumber1 = 0;
ushort ushortNumber2 = 65535;
```

That we can print on the console to see the numbers.

```c#
Console.WriteLine("Ushort Number 1: " + ushortNumber1.ToString());
Console.WriteLine("Ushort Number 2: " + ushortNumber2.ToString());
```
  
**Result:**
  
> Ushort Number 1: 0
> 
> Ushort Number 2: 65535

### Long

Is a signed integer, *long* is in the range -922337203685477508 to 922337203685477507.

```c#
long longNumber1 = -922337203685477508;
long longNumber2 = 922337203685477507;
```

That we can print on the console to see the numbers.

```c#
Console.WriteLine("Long Number 1: " + longNumber1.ToString());
Console.WriteLine("Long Number 2: " + longNumber2.ToString());
```
  
**Result:**
  
> Long Number 1: -922337203685477508
> 
> Long Number 2: 922337203685477507

### Ulong

Is a signed integer, *ulong* is in the range 0 to 18446744073709551615.

```c#
ulong ulongNumber1 = 0;
ulong ulongNumber2 = 18446744073709551615;
```

That we can print on the console to see the numbers.

```c#
Console.WriteLine("Ulong Number 1: " + ulongNumber1.ToString());
Console.WriteLine("Ulong Number 2: " + ulongNumber2.ToString());
```
  
**Result:**
  
> Ulong Number 1: 0
> 
> Ulong Number 2: 18446744073709551615

### Float

Is a single precision floating point type, *float* is in the range -3.402823e38 to 3.402823e38.

```c#
float floatNumber1 = -3.402823f;
float floatNumber2 = 3.402823f;
```

That we can print on the console to see the numbers.

```c#
Console.WriteLine("Float Number 1: " + floatNumber1.ToString());
Console.WriteLine("Float Number 2: " + floatNumber2.ToString());
```

**Result:**

> Float Number 1: -3.402823
> 
> Float Number 2: 3.402823

### Double

Is a double precision floating point type, *double* is in the range -1.79769313486232e308 to 1.79769313486232e308.

```c#
double doubleNumber1 = -1.79769313486232;
double doubleNumber2 = 1.79769313486232;
```

That we can print on the console to see the numbers.

```c#
Console.WriteLine("Double Number 1: " + doubleNumber1.ToString());
Console.WriteLine("Double Number 2: " + doubleNumber2.ToString());
```

**Result:**

> Double Number 1: -1.79769313486232
> 
> Double Number 2: 1.79769313486232

### Decimal

It is precise fractional or integral type, which can represent decimal numbers with 29 significant digital, *decimal* is in the range ±1.0 × 10e−28 to ±7.9 × 10e28.

```c#
decimal decimalNumber1 = -5.23456897M;
decimal decimalNumber2 = 5.23456897M;
```

That we can print on the console to see the numbers.

```c#
Console.WriteLine("Decimal Number 1: " + decimalNumber1.ToString());
Console.WriteLine("Decimal Number 2: " + decimalNumber2.ToString());
```

**Result:**

> Decimal Number 1: -5.23456897
> 
> Decimal Number 2: 5.23456897

### Char

Is an unicode character, the variable *char* can only be assigned a unicode symbol.

```c#
char charCharacter1 = 'A';
char charCharacter2 = 'G';
```

That we can print on the console to see the chars.

```c#
Console.WriteLine("Char 1: " + charCharacter1.ToString());
Console.WriteLine("Char 2: " + charCharacter2.ToString());
```

**Result:**

> Char 1: A
> 
> Char 2: G

### Bool

Is a logical boolean type, *bool* can only take values of true or false.

```c#
bool boolCharacter1 = false;
bool boolCharacter2 = true;
```

That we can print on the console to see the bools.

```c#
Console.WriteLine("Bool 1: " + boolCharacter1.ToString());
Console.WriteLine("Bool 2: " + boolCharacter2.ToString());
```

**Result:**

> Bool 1: False
> 
> Bool 2: True

### Object

Is the base type (father) of all other types.

```c#
object objectCharacter1 = "A";
object objectCharacter2 = 24;
object objectCharacter3 = true;
```

That we can print on the console to see the objects.

```c#
Console.WriteLine("Object 1: " + objectCharacter1.ToString());
Console.WriteLine("Object 2: " + objectCharacter2.ToString());
Console.WriteLine("Object 3: " + objectCharacter3.ToString());
```

**Result:**

> Object 1: A
> 
> Object 2: 24
> 
> Object 3: True

### String

It is a sequence of characters.

```c#
string stringText1 = "Character1";
string stringText2 = "Character2";
```

That we can print on the console to see the Strings.

```c#
Console.WriteLine("String 1: " + stringText1.ToString());
Console.WriteLine("String 2: " + stringText2.ToString());
```

**Result:**

> String 1: Character1
> 
> String 2: Character2

## Notes

Different methods we use in this code:

### Concatenate

Use it to add strings.

> String + String = String
> 
> Example: "A" + "B" = "AB"

### ToString()

Transform an *Object* to a *String*.

> (int).ToString() = String
>
> Example: 24.ToString() = "24"

### Console.WriteLine()

Function to write to the console.

> cw (use *Tab* x2) -> Console.WriteLine()

### Console.ReadLine()

Function to read the console or wait the process.
