using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int Amount { get; set; }
    private int _totalBreadCost = 0;
    private string _breadDetails = "";
    public Bread(int amount)
    {
      if (amount == 2)
      {
        amount = 3;
      }
      Amount = amount;
      _totalBreadCost = breadTotalLogic(Amount);
      _breadDetails = breadDetailsLogic(Amount);
    }

    public static int breadTotalLogic(int userAmount)
    {
      int x = userAmount / 3;
      int y = x * 3;
      int z = userAmount - y;
      int total = (z * 5) + (x * 10);
      return total;
    }
    public static string breadDetailsLogic(int userAmount)
    {
      if (userAmount == 1)
      {
        return "1 Loaf of Bread";
      }
      else
      {
        return userAmount + " Loaves of Bread";
      }
    }
    public int returnBreadTotalCost()
    {
      return _totalBreadCost;
    }
    public string returnAmountofBread()
    {
      return _breadDetails;
    }
  }
}