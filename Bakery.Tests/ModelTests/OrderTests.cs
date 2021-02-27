using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Bread",(3,15));
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderType_ReturnsCurrentOrderType_String()
    {
      (int, int) currentOrder = (3, 5);
      string orderType = "Pastries";

      Order newOrder = new Order(orderType, currentOrder);
      string result = newOrder.Type;
      
      Assert.AreEqual(result, orderType);
    }

    [TestMethod]
    public void GetOrderType_ReturnsCurrentOrderType_Int()
    {
      (int, int) currentOrder = (3, 5);
      string orderType = "Pastries";

      Order newOrder = new Order(orderType, currentOrder);
      (int, int) result = newOrder.CurrentOrder;
      
      Assert.AreEqual(result, currentOrder);
    }
    [TestMethod]
    public void GetOrder_ReturnsEmptyList_OrderList()
    {
      List<Order> newOrder = new List<Order> { };

      List<Order> result = Order.GetOrder();

      CollectionAssert.AreEqual(newOrder, result);
    }
    [TestMethod]

    public void GetOrder_ReturnsOrders_OrderList()
    {
      (int, int) currentOrder = (3, 5);
      string orderType = "Pastries";
      Order newOrder = new Order(orderType, currentOrder);
      List<Order> newList = new List<Order> { newOrder };

      List<Order> result = Order.GetOrder();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}