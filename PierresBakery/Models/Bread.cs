using System; 
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public static int GetBreadPrice(int input)
    {
      int price = 5;
      int discount = 0;
      if (input >= 3)
      {
        discount = input / 3;
      }
      return (input * price) - (discount * price);
    }
  }
}