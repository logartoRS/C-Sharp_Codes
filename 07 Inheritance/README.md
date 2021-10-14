# Inheritance

Inheritance is the most important feature of object-oriented programming, because it helps us create new classes based on base classes. With inheritance in the new classes we can modify all the characteristics such as new variables or properties, modify methods or create new methods for the new class.
The new class or derived class is a specialization of the base class. We can create many derived classes from the base class. These derived classes will have the same properties and methods as the base class.

## Creating the base class

Creating the base class is similar to creating any class. In this class we will declare all the properties, get, sets, constructors and methods that all derived classes will use. In this case we will create a class called *Species*.

```c#
class Species
{
  // Properties
  private String name;
  private String scientificName;

  // Gets and Sets
  public String Name
  {
    get	{ return name; }
    set	{ name = value; }
  }
  public String ScientificName
  {
    get { return scientificName; }
    set	{ scientificName = value; }
  }

  // Default constructor
  public Species()
  {
    this.name = "";
    this.scientificName = "";
  }

  // Parameterized constructor
  public Species(String name, String scientificName)
  {
    this.name = name;
    this.scientificName = scientificName;
  }

  // Methods
  public void mention()
  {
    Console.WriteLine("Name: {0}", this.name);
    Console.WriteLine("Scientific name: {0}", this.scientificName);
  }
}
```

## Creating a derived class

Now with the base class created, we can create many different derived classes. If we want to create a derived class, we need to create a class with the following format.

```c#
class Animal:Species
```

This declaration says that the new class is a derived class named *Animal* from the base class named *Species*. In this case, we will create a new derived class called *Animal* and *Plant*.

### Derived Class Animal

```c#
class Animal:Species
{
  // Properties
  private int size;
  private int weight;

  // Gets and Sets
  public int Size
  {
    get { return size; }
    set { size = value; }
  }
  public int Weight
  {
    get { return weight; }
    set { weight = value; }
  }

  // Default constructor
  public Animal() { }

  // Parameterized constructor
  public Animal(String name, String scientificName, int size, int weight):base(name, scientificName)
  {
    this.size = size;
    this.weight = weight;
  }

  // Methods
  public void mention()
  {
    Console.WriteLine("Name: {0}", Name);
    Console.WriteLine("Scientific name: {0}", ScientificName);
    Console.WriteLine("Average size: {0}", this.size);
    Console.WriteLine("Average weight: {0}", this.weight);
  }
}
```

### Derived Class Plant

```c#
class Plant:Species
{
  // Properties
  private String color;
  private int size;
  private bool hasFruit;

  // Gets and Sets
  public String Color
  {
    get { return color; }
    set { color = value; }
  }
  public int Size
  {
    get { return size; }
    set { size = value; }
  }
  public bool HasFruit
  {
    get { return hasFruit; }
    set { hasFruit = value; }
  }

  // Default constructor
  public Plant() { }

  // Parameterized constructor
  public Plant(String name, String scientificName, String color, int size, bool hasFruit) : base(name, scientificName)
  {
    this.color = color;
    this.size = size;
    this.hasFruit = hasFruit;
  }

  // Methods
  public void mention()
  {
    Console.WriteLine("Name: {0}", Name);
    Console.WriteLine("Scientific name: {0}", ScientificName);
    Console.WriteLine("Color: {0}", this.color);
    Console.WriteLine("Average size: {0}", this.size);
    Console.WriteLine("Has Fruit: {0}", this.hasFruit);
  }
}
```

## Use the derived classes

Now with the new derived classes we can use the classes as a normal class, but the interesting thing is that we can use the properties or methods of the base class.

```c#
class Program
{
  static void Main(string[] args)
  {
    Animal dog = new Animal("Dog", "Canis familiaris", 50, 20);
    Plant appleTree = new Plant("Apple Tree", "Malus domestica", "Green", 10, true);

    dog.mention();
    appleTree.mention();

    Console.ReadLine();
  }
}
```

**Result:**

> Name: Dog
> 
> Scientific name: Canis familiaris
> 
> Average size: 50
> 
> Average weight: 20

> Name: Apple Tree
> 
> Scientific name: Malus domestica
> 
> Color: Green
> 
> Average size: 10
> 
> Has Fruit: True
