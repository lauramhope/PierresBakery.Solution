using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PierresBakery.Models;

namespace PierresBakery
{
  class Program
  {
    static void Main() 
    {
      try 
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome to Pierre's Bakery!");
        Console.WriteLine("Bread is $5 per loaf, or buy 2 get 1 free!");
        Console.WriteLine("~* Every 3rd loaf is free *~");
        Console.WriteLine("Pastries are $2 each, or buy 3 get 1 free!");
        Console.WriteLine("~* Every 4th pastry is free *~");
        Console.ResetColor();

        Console.WriteLine("How many loaves of bread would you like?");
        int breadQuantity = int.Parse(Console.ReadLine());
        Console.WriteLine("How many pastries would you like?");
        int pastryQuantity = int.Parse(Console.ReadLine());
        Bread newBread = new Bread(breadQuantity);
        Pastry newPastry = new Pastry(pastryQuantity);
        int breadPrice = newBread.GetBreadPrice(breadQuantity);
        int pastryPrice = newPastry.GetPastryPrice(pastryQuantity);
        int totalPrice = breadPrice + pastryPrice;
        Console.WriteLine("Your total is $" + totalPrice + ". Thank you for shopping at Pierre's Bakery!");
      }
      catch (Exception ex)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Message = {0}", ex.Message);
        Console.WriteLine("Please enter a valid number.");
        Console.ResetColor();
        Main();
      }
    }
  }
}