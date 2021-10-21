# Polymorphism

Polymorphism is another characteristic of object-oriented programming. Polymorphism is commonly used to modify methods between classes and derived classes.

## Virtual - Override

*Virtual* is a reserved word that is normally used in the main class method. This method enabled the *Override* keyword that is normally used in the derived class. when we override a method of the derived class, this method of the main class will be overwritten.

**Main Class**

```c#
public virtual void showData()
{
  Console.WriteLine("Measure: {0}", Measure);
  Console.WriteLine("Weight: {0}", Weight);
  Console.WriteLine("Volttage: {0}", Volttage);
  Console.WriteLine("Warranty: {0}", Warranty);
}
```

**Derived Class**

```c#
public override void showData()
{
  Console.WriteLine("Measure: {0}", Measure);
  Console.WriteLine("Weight: {0}", Weight);
  Console.WriteLine("Volttage: {0}", Volttage);
  Console.WriteLine("Warranty: {0}", Warranty);
  Console.WriteLine("Company: {0}", Company);
  Console.WriteLine("Model: {0}", Model);
}
```

## New

New is a reserved word that is normally used to rewrite a method, but when we use this reserved word, we have the capacity to use both methods, of the main class and od the derived class, depending on how we declare the object.

**Main Class**

```c#
public void showCompany()
{
  Console.WriteLine("This company has no company.");
}
```

**Derived Class**

```c#
public new void showCompany()
{
  Console.WriteLine("The microwane's company is {0}.", Company);
}
```

## Sealed

*Sealed* is a reserved word normally used in classes or methods that is used to prevent classes and methods from being derived or rewritten respectively.

```c#
sealed class Microwave : Artefact
{
  // Code
}
```

### Using methods with reserved words

**Code 1:**

```c#
var artefatcs = new List<Artefact>
{
  new Artefact(150, 75, 110, "3 years"),
  new Microwave(75, 15, 220, "2 years", "Microwave SAC", "SKN 145")
};

foreach(var artefact in artefatcs)
{
  artefact.showData();
  artefact.showCompany();
  Console.Write("\n");
}
```

**Result:**

> Measure: 150
> 
> Weight: 75
> 
> Volttage: 110
> 
> Warranty: 3 years
> 
> This company has no company.

> Measure: 75
> 
> Weight: 15
> 
> Volttage: 220
> 
> Warranty: 2 years
> 
> Company: Microwave SAC
> 
> Model: SKN 145
> 
> This company has no company.

**Code 2:**

```c#
Microwave microwave1 = new Microwave(75, 15, 220, "2 years", "OGTA", "OGT 187");
microwave1.showData();
microwave1.showCompany();
Console.Write("\n");
```

**Result:**

> Measure: 75
> 
> Weight: 15
> 
> Volttage: 220
> 
> Warranty: 2 years
> 
> Company: OGTA
> 
> Model: OGT 187
> 
> The microwane's company is OGTA.
