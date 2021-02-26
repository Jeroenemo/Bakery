using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to my Bakery!");
      Console.WriteLine("Enter 'B' for bread, 'P' for pastries, or 'Q' to leave");
      string userInput = Console.ReadLine().ToUpper();
      switch (userInput)
      {
        case "B":
          Console.WriteLine("How many loaves would you like?");
          int breadQuantity = int.Parse(Console.ReadLine());
          Bread newBread = new Bread(breadQuantity);
          (int,int) breadResult = newBread.ClaculatePrice();
          Console.WriteLine("Your total for {0} loaves is ${1}", breadResult.Item2, breadResult.Item1);
          Main();
          break;

        case "P":
          Console.WriteLine("How many pastries would you like?");
          int pastryQuantity = int.Parse(Console.ReadLine());
          Pastry newPastry = new Pastry(pastryQuantity);
          (int, int) pastryResult = newPastry.ClaculatePrice();
          Console.WriteLine("Your total for {0} pastries is ${1}", pastryResult.Item2, pastryResult.Item1);
          Main();
          break;

        case "Q":
          Console.WriteLine("Have a nice day!");
          break;

        default:
          Console.WriteLine("Please enter a valid input");
          Main();
          break;
      }
    }
  }
}