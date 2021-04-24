using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("----------------------");
      Console.WriteLine("Here is our menu:");
      Console.WriteLine("Bread:");
      Console.WriteLine("$5/Loaf - Buy 2, Get One Free");
      Console.WriteLine("Pastry:");
      Console.WriteLine("$2/Pastry - 3 Pastries for $5");
      Console.WriteLine("How much bread would you like?");
      Console.WriteLine("(Enter the amount as a number)");
      Console.WriteLine("");
      int breadInput = int.Parse(System.Console.ReadLine());
      Bread newBread = new Bread(breadInput);
      int breadCost = newBread.returnBreadTotalCost();
      string breadDetails = newBread.returnAmountofBread();
      Console.WriteLine($"{breadDetails} righttt");

      // String Console.ReadLine();

    }
  }
}