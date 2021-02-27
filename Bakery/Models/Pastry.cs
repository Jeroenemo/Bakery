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
      int numberOfDeals = (Quantity / 3);
      int remainingPastries = Quantity - (numberOfDeals * 3);
      int total = (numberOfDeals * 5) + (remainingPastries * 2);
      return (total, Quantity);
    }
  }
}
