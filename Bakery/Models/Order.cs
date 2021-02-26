using System;
using System.Collections.Generic;


namespace Bakery.Models
{
  public  class Order
  {
    public Object ThisOrder { get; set; }
    private static List<Order> _order = new List<Order> {};

    public Order(Object order)
    {
      ThisOrder = order;
      _order.Add(this);
    }

    public static List<Order> GetAll()
    {
      return _order;
    }
    
  }
}