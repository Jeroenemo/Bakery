using System;
using System.Collections.Generic;


namespace Bakery.Models
{
  public  class Order
  {
    public (int, int) CurrentOrder { get; }
    public string Type { get; }
    private static List<Order> _order = new List<Order> {};

    public Order(string type, (int, int) order)
    {
      CurrentOrder = order;
      Type = type;

      _order.Add(this);
    }

    public static List<Order> GetOrder()
    {
      return _order;
    }
    
    public static void ClearAll()
    {
      _order.Clear();
    }
  }
}