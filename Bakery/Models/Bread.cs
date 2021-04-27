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
      _totalBreadCost = BreadTotalLogic(Amount);
      _breadDetails = BreadDetailsLogic(Amount);
    }

    public int BreadTotalLogic(int userAmount)
    {
      int x = userAmount / 3;
      int y = x * 3;
      int z = userAmount - y;
      int total = (z * 5) + (x * 10);
      return total;
    }

    public string BreadDetailsLogic(int userAmount)
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

    public int ReturnBreadTotalCost()
    {
      return _totalBreadCost;
    }
    public string ReturnAmountofBread()
    {
      return _breadDetails;
    }
  }
}