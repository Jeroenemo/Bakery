using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void SetQuantity_ReturnsQuantity_Int()
    {
      int quantity = 8;

      Pastry newPastry = new Pastry(8);
      int result = newPastry.Quantity;

      Assert.AreEqual(quantity, result);
    }
  }
}