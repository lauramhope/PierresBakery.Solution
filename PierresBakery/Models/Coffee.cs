using System; 
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Coffee 
  {
    public int CoffeeOrder { get; set; }
    public Coffee(int coffeeQuantity)
    {
      CoffeeOrder = coffeeQuantity;
    }
    public int GetCoffeePrice(int input)
    {
      int totalPrice = 0;
      int price = 3;
      totalPrice = input * price;
      return totalPrice;
    }
  }
}