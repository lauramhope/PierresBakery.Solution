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
  }
}