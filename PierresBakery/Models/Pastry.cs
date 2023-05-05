using System; 
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public static int GetPastryPrice(int input)
    {
      int price = 2;
      int discount = 0;
      if (input >= 4)
      {
        discount = input / 4;
      }
      return (input * price) - (discount * price);
    }
  }
}