using System;

namespace Bakery.Models
{
    public class Bread
  {
    public int UnitPrice { get; set; }
    public int Quantity { get; set; }
    public Bread(int desiredQuantity)
    {
      Quantity = desiredQuantity;
      UnitPrice = 5;
    }
    public void ClaculatePrice()
    {
      int updatedQuantity = Quantity;
      for (int i = 0; i < Quantity; i++)
      {
        if (i % 2 == 0)
        {
          updatedQuantity ++;
        }
      }
      Console.WriteLine("You got {0} loaves for ${1} -- {2} loaves where free!", updatedQuantity, (Quantity * UnitPrice), (updatedQuantity - Quantity));
    }
  }
}