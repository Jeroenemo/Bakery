using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("MAIN MENU");
      Console.WriteLine("Enter 'B' for bread, 'P' for pastries, 'C' to checkout, or 'Q' to leave");
      string userInput = Console.ReadLine().ToUpper();
      switch (userInput)
      {
        case "B":
          Console.WriteLine("It's $5 per loaf, Buy 2 get 1 Free! How many loaves would you like?");
          int breadQuantity = int.Parse(Console.ReadLine());
          Bread newBread = new Bread(breadQuantity);
          (int,int) breadResult = newBread.ClaculatePrice();
          Order breadOrder = new Order("Bread", breadResult);
          Main();
          break;

        case "P":
          Console.WriteLine("It's $2 per pastry, 3 for $5! How many pastries would you like?");
          int pastryQuantity = int.Parse(Console.ReadLine());
          Pastry newPastry = new Pastry(pastryQuantity);
          (int, int) pastryResult = newPastry.ClaculatePrice();
          Order pastryOrder = new Order("Pastry", pastryResult);
          Main();
          break;
        case "C":
          List<Order> allOrders = Order.GetOrder();
          int grandTotal = 0;
          foreach (Order thisOrder in allOrders)
          {
            grandTotal += thisOrder.CurrentOrder.Item1;
            Console.WriteLine("----------------------");
            Console.WriteLine("{0}: {1} for ${2}", thisOrder.Type, thisOrder.CurrentOrder.Item2, thisOrder.CurrentOrder.Item1);
            // Console.WriteLine(thisOrder.CurrentOrder.Item1 + thisOrder.Type);
          }
          Console.WriteLine("----------------------");
          Console.WriteLine("Your grand total is ${0}", grandTotal);
          Console.WriteLine("Have a nice day!");
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