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

    public void ClaculatePrice()
    {
      int total = 0;
      for (int i = 0; i < Quantity; i++)
      {
        total += 2;
        if ( i % 3 == 0)
        {
          total --;

        }
      }
      Console.WriteLine("You got {0} Pastries for ${1} -- with a discount of ${2}", Quantity, total, (Quantity * UnitPrice - total));
    }
  }
}
