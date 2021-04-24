using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Amount { get; set; }
    private int _totalPastriesCost = 0;
    private string _pastryDetails = "";
    public Pastry(int amount)
    {
      Amount = amount;
      _totalPastriesCost = pastryTotalLogic(Amount);
      _pastryDetails = pastryDetailsLogic(Amount);
    }

    public static int pastryTotalLogic(int userAmount)
    {
      int x = userAmount / 3;
      int y = x * 3;
      int z = userAmount - y;
      int total = (z * 2) + (x * 5);
      return total;
    }

    public static string pastryDetailsLogic(int userAmount)
    {
      if (userAmount == 1)
      {
        return "1 Pastry";
      }
      else
      {
        return userAmount + " Pastries";
      }
    }

    public int returnPastryTotalCost()
    {
      return _totalPastriesCost;
    }
    public string returnAmountofPastries()
    {
      return _pastryDetails;
    }

  }
}