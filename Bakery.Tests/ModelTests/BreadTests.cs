using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void SetQuantity_ReturnsQuantity_Int()
    {
      int quantity = 10;

      Bread newBread = new Bread(10);
      int result = newBread.Quantity;

      Assert.AreEqual(quantity, result);
    }

    [TestMethod]
    public void CalculatePrice_ReturnsPrice_Int()
    {
      int quantity = 1;
      
      Bread newBread = new Bread(quantity);
      (int, int) result = newBread.ClaculatePrice();

      Assert.AreEqual((5, 1), result);
    }

    [TestMethod]
    public void CalculateDiscount_ReturnsDiscount_Int()
    {
      int quantity = 4;
      
      Bread newBread = new Bread(quantity);
      (int, int) result = newBread.ClaculatePrice();

      Assert.AreEqual((20, 6), result);
    }
  }
}