using System;

namespace Bakery.Models
{
    public class Pastry
  {
    public int UnitPrice { get; set; }
    public int Quantity { get; set; }
    public Pastry(int desiredQuantity)
    {
      Quantity = desiredQuantity;
      UnitPrice = 2;
    }

    public (int, int) ClaculatePrice()
    {
      int total = 0;
      for (int i = 1; i <= Quantity; i++)
      {
        total += 2;
        if ( i % 3 == 0)
        {
          total --;

        }
      }
      return (total, Quantity);
    }
  }
}
