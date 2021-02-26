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
    public (int, int) ClaculatePrice()
    {
      int total = Quantity * UnitPrice;
      int updatedQuantity = Quantity;
      for (int i = 1; i <= Quantity; i++)
      {
        if (i % 2 == 0)
        {
          updatedQuantity ++;
        }

      }
      return (total, updatedQuantity);
    }
  }
}
      // if (Quantity == 1)
      // {
      //   Console.WriteLine("You got {0} loaf for ${1}", Quantity, UnitPrice);
      // }
      // Console.WriteLine("You got {0} loaves for ${1} -- {2} loaves where free!", updatedQuantity, (Quantity * UnitPrice), (updatedQuantity - Quantity));