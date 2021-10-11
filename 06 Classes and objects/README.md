# Classes and objects

A class is a structure that has its own variables, properties, methods, among others. It is similar to the main file, because it has the same structure. That class loaded in memory is called an object or instance, this object has its own characteristics given by the class.

## Create a class

We need to create, in the main script or other script in the same folder, a structure like in the next code.

```c#
class Animal
{
  // Properties

  // Gets and Sets

  // Constructors

  // Methods

}
```

The content of the class is not defined in a specific structure. We can write the code however we want, but there are conventions on how to structure a class, in this way developers can better understand the code of others.

### Properties, Get and Set

A property is a member in code that has a mechanism to use as read or write. Properties are normally to be used in protected mode, it is not a condition, but it helps us that the property cannot be directly accessed and used. We can use Gets and Sets to access properties.

```c#
// Properties
private String name;
private String scientificName;
private int size;
private int weight;

// Gets and Sets
public String Name
{
  get
  {
    return name;
  }
  set
  {
    name = value;
  }
}
public String ScientificName
{
  get
  {
    return scientificName;
  }
  set
  {
    scientificName = value;
  }
}
public int Size
{
  get
  {
    return size;
  }
  set
  {
    size = value;
  }
}
public int Weight
{
  get
  {
    return weight;
  }
  set
  {
    weight = value;
  }
}
```

### Constructors
The constructor is the part of the class that is used to create the object. The class can have many different constructors, and each constructor executes the code it contains. It is normal to use constructors to give the object the capacity to value the properties of the object determined by the class. It is also normal to create a default constructor that gives the object the default values of the properties.

```c#
// Default constructor
public Animal()
{
  this.name = "Dog";
  this.scientificName = "Canis familiaris";
  this.size = 50;
  this.weight = 20;
}

// Parameterized constructor
public Animal(String name, String scientificName, int size, int weight)
{
  this.name = name;
  this.scientificName = scientificName;
  this.size = size;
  this.weight = weight;
}
```

### Methods
Created objects have the ability to access methods, these methods must be declared in the class code.

```c#
// Methods
public void description()
{
  Console.WriteLine("Name: {0}", this.name);
  Console.WriteLine("Scientific name: {0}", this.scientificName);
  Console.WriteLine("Average size: {0} cm", this.size);
  Console.WriteLine("Average weight: {0} Kg", this.weight);
}
```
