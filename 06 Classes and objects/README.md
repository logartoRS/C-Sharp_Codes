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

A property is a member in code that has a mechanism to use as read or write. Properties are normally to be used in protected mode, it is not a condition, but it helps us that the property cannot be directly accessed and used.

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
