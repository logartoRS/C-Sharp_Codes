# Enumeration

Enumeration is a type of value that enumerates a set of constants that are related by the name of the enum. We can change the order number in the enum depending on what is required.

## Declaring the enum

```c#
enum Season
{
  Spring,
  Summer,
  Autumn,
  Winter
}

enum Day
{
  Mo = 2,
  Tu,
  We,
  Th,
  Fr = 13,
  Sa,
  Su
}

Season spring = Season.Spring;
Day monday = Day.Mo;

Season[] seasons = new Season[4] { Season.Spring, Season.Summer, Season.Autumn, Season.Winter };
Day[] days = new Day[7] { Day.Mo, Day.Tu, Day.We, Day.Th, Day.Fr, Day.Sa, Day.Su };
```

## Using the Enum

```c#
Console.WriteLine(spring);
Console.WriteLine((int)spring);
```

**Result:**

> Spring
> 
> 0

```c#
Console.WriteLine(monday);
Console.WriteLine((int)monday);
```

**Result:**

> Mo
> 
> 2

```c#
foreach (Season season in seasons)
{
  Console.WriteLine(season);
  Console.WriteLine((int)season);
}
```

**Result:**

> Spring
> 
> 0
> 
> Summer
> 
> 1
> 
> Autumn
> 
> 2
> 
> Winter
> 
> 3

```c#
foreach(Day day in days)
{
  Console.WriteLine(day);
  Console.WriteLine((int)day);
}
```

**Result:**

> Mo
> 
> 2
> 
> Tu
> 
> 3
> 
> We
> 
> 4
> 
> Th
> 
> 5
> 
> Fr
> 
> 13
> 
> Sa
> 
> 14
> 
> Su
> 
> 15
