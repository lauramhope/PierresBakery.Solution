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
    
  }
}