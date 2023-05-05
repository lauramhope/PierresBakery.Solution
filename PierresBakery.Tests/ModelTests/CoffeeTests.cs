using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class CoffeeTests
  {
    Coffee newCoffee = new Coffee(1);
    [TestMethod]
    public void CoffeeConstructor_CreatesInstanceOfCoffee_Coffee()
    {
      Assert.AreEqual(typeof(Coffee), newCoffee.GetType());
    }

    [TestMethod]
    public void GetCoffeePrice_ReturnsCoffeePrice_Int()
    {
      Assert.AreEqual(3, newCoffee.GetCoffeePrice(1));
    }
  }
}