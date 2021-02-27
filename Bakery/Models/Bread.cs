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
      int updatedQuantity = Quantity + (Quantity / 2);
      return (total, updatedQuantity);
    }
  }
}
