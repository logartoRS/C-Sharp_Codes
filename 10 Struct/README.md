# Struct

A *struct* is a type that encapsulates data as properties and / or methods. *Struct* is similar to the class but it does not have all the functionalities of the class. *Struct* does not support inheritance, the default constructors.

## Declare struct

```c#
struct Fruit
{
  private int Amount { get; set; }
  private int Price { get; set; }
  private String Name { get; set; }

  public Fruit(int amount, int price, String name)
  {
    this.Amount = amount;
    this.Price = price;
    this.Name = name;
  }

  public int totalPrice()
  {
    return Price * Amount;
  }
}
```

## Using struct

```c#
Fruit pear = new Fruit(5, 10, "Pear");
Console.WriteLine("The total price of the product is: {0}", pear.totalPrice());
```

**Result:**

> The total price of the product is: 50
