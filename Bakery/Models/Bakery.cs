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
    public int ClaculatePrice()
    {
      
    }
  }

    public class Pastry
  {
      public int UnitPrice { get; set; }
      public int Quantity { get; set; }
    public Pastry(int desiredQuantity)
    {
      Quantity = desiredQuantity;
      UnitPrice = 3;
    }
  }
}
