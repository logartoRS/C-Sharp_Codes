using System;

namespace _10_Struct
{
	class Program
	{
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

		static void Main(string[] args)
		{
			Fruit pear = new Fruit(5, 10, "Pear");

			Console.WriteLine("The total price of the product is: {0}", pear.totalPrice());

			Console.ReadLine();
		}
	}
}
