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

    [TestMethod]
    public void CalculatePrice_ReturnsPrice_Int()
    {
      int quantity = 1;
      
      Pastry newPastry = new Pastry(quantity);
      (int, int) result = newPastry.ClaculatePrice();

      Assert.AreEqual((2, 1), result);
    }

    [TestMethod]
    public void CalculateDiscount_ReturnsDiscount_Int()
    {
      int quantity = 6;
      
      Pastry newPastry = new Pastry(quantity);
      (int, int) result = newPastry.ClaculatePrice();

      Assert.AreEqual((10, 6), result);
    }
  }
}