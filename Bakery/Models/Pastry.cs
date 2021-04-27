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
      _totalPastriesCost = PastryTotalLogic(Amount);
      _pastryDetails = PastryDetailsLogic(Amount);
    }

    public int PastryTotalLogic(int userAmount)
    {
      int x = userAmount / 3;
      int y = x * 3;
      int z = userAmount - y;
      int total = (z * 2) + (x * 5);
      return total;
    }

    public string PastryDetailsLogic(int userAmount)
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

    public int ReturnPastryTotalCost()
    {
      return _totalPastriesCost;
    }

    public string ReturnAmountofPastries()
    {
      return _pastryDetails;
    }

  }
}