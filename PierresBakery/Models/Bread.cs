using System; 
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadOrder { get; set; }
    public Bread(int breadQuantity)
    {
      BreadOrder = breadQuantity;
    }
    public int GetBreadPrice(int input)
    {
      int totalPrice = 0;
      int price = 5;
      int discountTotal = input/3;
      int discount = discountTotal * price;
      totalPrice = (input * price) - discount;
      return totalPrice;
    }
  }
} 