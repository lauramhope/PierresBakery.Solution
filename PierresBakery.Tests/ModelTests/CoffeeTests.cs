using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class CoffeeTests
  {
    Coffee newCoffee = new Coffee();
    [TestMethod]
    public void CoffeeConstructor_CreatesInstanceOfCoffee_Coffee()
    {
      Assert.AreEqual(typeof(Coffee), newCoffee.GetType());
    }

  }
}