using System; 
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryOrder { get; set; }
    public Pastry(int pastryQuantity)
    {
      PastryOrder = pastryQuantity;
    }
    public int GetPastryPrice(int input)
    {
      int totalPrice = 0;
      int price = 2;
      int discountTotal = input/4;
      int discount = discountTotal * price;
      totalPrice = (input * price) - discount;
      return totalPrice;
    }
  }
}