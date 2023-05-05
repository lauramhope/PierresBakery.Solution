using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    Pastry newPastry = new Pastry(); 
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod] 
    public void GetPastryPrice_ReturnsPastryPrice_Int()
    {
      Assert.AreEqual(2, Pastry.GetPastryPrice(1));
    }

    [TestMethod]
    public void GetPastryPrice_ReturnsPastryPriceWithDiscount_Int()
    {
      Assert.AreEqual(6, Pastry.GetPastryPrice(3));
    }

    [TestMethod]
    public void GetPastryPrice_ReturnsPastryPriceWithDiscount1_Int()
    {
      Assert.AreEqual(6, Pastry.GetPastryPrice(4));
    }

    [TestMethod]
    public void GetPastryPrice_ReturnsPastryPriceWithDiscount2_Int()
    {
      Assert.AreEqual(8, Pastry.GetPastryPrice(5));
    }

    [TestMethod]
    public void GetPastryPrice_ReturnsPastryPriceWithDiscount3_Int()
    {
      Assert.AreEqual(12, Pastry.GetPastryPrice(8));
    }
  }
}