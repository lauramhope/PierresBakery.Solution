using System;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main() 
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Bread is $5 per loaf, or buy 2 get 1 free!");
      Console.WriteLine("~* Every 3rd loaf is free *~");
      Console.WriteLine("Pastries are $2 each, or buy 3 get 1 free!");
      Console.WriteLine("~* Every 4th pastry is free *~");
      Console.ResetColor();

      Bread newBread = new Bread();
      Pastry newPastry = new Pastry();

      Console.WriteLine("How many loaves of bread would you like?");
      int breadInput = int.Parse(Console.ReadLine());

      Console.WriteLine("How many pastries would you like?");
      int pastryInput = int.Parse(Console.ReadLine());

      int breadPrice = Bread.GetBreadPrice(breadInput);
      int pastryPrice = Pastry.GetPastryPrice(pastryInput);
      int totalPrice = breadPrice + pastryPrice;
      Console.WriteLine("Your total is $" + totalPrice + ".00");
    }
  }
}