using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      MenuPopUp();
      Transaction();
    }

    static void MenuPopUp()
    {
      Console.WriteLine("");
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("----------------------");
      Console.WriteLine("Here is our menu:");
      Console.WriteLine("Bread:");
      Console.WriteLine("$5/Loaf - Buy 2, Get One Free");
      Console.WriteLine("Pastry:");
      Console.WriteLine("$2/Pastry - 3 Pastries for $5");
    }

    static void Transaction()
    {
      Console.WriteLine("");
      Console.WriteLine("How much bread would you like?");
      Console.WriteLine("(Enter the amount of loaves as a number)");
      Console.WriteLine("");

      int breadInput = int.Parse(System.Console.ReadLine());
      Bread newBread = new Bread(breadInput);
      int breadCost = newBread.ReturnBreadTotalCost();
      string breadDetails = newBread.ReturnAmountofBread();

      Console.WriteLine("");
      Console.WriteLine("How many pastries would you like?");
      Console.WriteLine("(Enter the amount of pastries as a number)");
      Console.WriteLine("");

      int pastryInput = int.Parse(System.Console.ReadLine());
      Pastry newpastry = new Pastry(pastryInput);
      int pastryCost = newpastry.ReturnPastryTotalCost();
      string pastryDetails = newpastry.ReturnAmountofPastries();
      Console.WriteLine("");

      int orderTotal = pastryCost + breadCost;
      Console.WriteLine($"Your order is ${orderTotal}");
      Console.WriteLine($"{pastryDetails} and {breadDetails}");
      Console.WriteLine("");
    }
  }
}