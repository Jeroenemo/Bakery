using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    // [TestMethod]
    // public void AddBread_ReturnBread_bread()
    // {
    //   Bread newBread = new Bread();

    //   Order newOrder = new Order(newBread);
    //   object result = newOrder.newBread;

    //   Assert.AreEqual(newOrder, result);
    // }
  }
}