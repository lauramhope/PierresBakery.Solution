using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  { 
    Bread newBread = new Bread();
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    
    [TestMethod]
    public void GetBreadPrice_ReturnsBreadPrice_Int()
    {
      Assert.AreEqual(5, Bread.GetBreadPrice(1));
    }

    [TestMethod]
    public void GetBreadPrice_ReturnsBreadPriceWithDiscount_Int()
    {
      Assert.AreEqual(10, Bread.GetBreadPrice(3));
    }

    [TestMethod]
    public void GetBreadPrice_ReturnsBreadPriceWithDiscountAndRemainder_Int()
    {
      Assert.AreEqual(15, Bread.GetBreadPrice(4));
    }

  }
}