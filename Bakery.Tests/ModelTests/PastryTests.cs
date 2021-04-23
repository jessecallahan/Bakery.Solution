using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetAmount_ReturnsPastryAmount_Int()
    {
      int userInput = 1;
      Pastry newPastry = new Pastry(userInput);
      int result = newPastry.Amount;
      Assert.AreEqual(userInput, result);
    }

    [TestMethod]
    public void ReturnPastryTotalCost_ReturnsPastryTotalCostTest1_Int()
    {
      int userInput = 0;
      Pastry newPastry = new Pastry(userInput);
      int result = newPastry.returnPastryTotalCost();
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void ReturnPastryTotalCost_ReturnsPastryTotalCostTest2_Int()
    {
      int userInput = 1;
      Pastry newPastry = new Pastry(userInput);
      int result = newPastry.returnPastryTotalCost();
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void ReturnPastryTotalCost_ReturnsPastryTotalCostTest3_Int()
    {
      int userInput = 2;
      Pastry newPastry = new Pastry(userInput);
      int result = newPastry.returnPastryTotalCost();
      Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void ReturnPastryTotalCost_ReturnsPastryTotalCostTest4_Int()
    {
      int userInput = 3;
      Pastry newPastry = new Pastry(userInput);
      int result = newPastry.returnPastryTotalCost();
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void ReturnPastryTotalCost_ReturnsPastryTotalCostTest5_Int()
    {
      int userInput = 100;
      Pastry newPastry = new Pastry(userInput);
      int result = newPastry.returnPastryTotalCost();
      Assert.AreEqual(167, result);
    }

    [TestMethod]
    public void ReturnAmountofPastries_ReturnsPastryDetailsTest1_String()
    {
      int userInput = 1;
      Pastry newPastry = new Pastry(userInput);
      string result = newPastry.returnAmountofPastries();
      Assert.AreEqual("1 pastry", result);
    }



  }
}