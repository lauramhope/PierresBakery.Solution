using System; 
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    // public int PastryOrder { get; set; }
    // public Pastry(int pastryQuantity)
    // {
    //   PastryOrder = pastryQuantity;
    // }
    // public int GetPastryPrice(int pastryQuantity)
    // {
    //   int price = 2;
    //   int discount = 0;
    //   if (pastryQuantity >= 4)
    //   {
    //     discount = pastryQuantity / 4;
    //   }
    //   return (pastryQuantity * price) - (discount * price);
    // }
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