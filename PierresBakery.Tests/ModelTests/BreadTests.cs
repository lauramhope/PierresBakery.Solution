using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  { 
    Bread newBread = new Bread(1);
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadPrice_ReturnsBreadPrice_Int()
    {
      Assert.AreEqual(5, newBread.GetBreadPrice(1));
    }

    [TestMethod]
    public void GetBreadPrice_ReturnsBreadPriceWithDiscount_Int()
    {
      Assert.AreEqual(10, newBread.GetBreadPrice(3));
    }

    [TestMethod]
    public void GetBreadPrice_ReturnsBreadPriceWithDiscount1_Int()
    {
      Assert.AreEqual(15, newBread.GetBreadPrice(4));
    }

    [TestMethod]
    public void GetBreadPrice_ReturnsBreadPriceWithDiscount2_Int()
    {
      Assert.AreEqual(20, newBread.GetBreadPrice(5));
    }

    [TestMethod]
    public void GetBreadPrice_ReturnsBreadPriceWithDiscount3_Int()
    {
      Assert.AreEqual(20, newBread.GetBreadPrice(6));
    }

  }
}