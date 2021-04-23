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
      Assert.AreEqual(4, result);
    }

    // [TestMethod]
    // public void PastryTotal_ReturnsPastryDetails_String()
    // {
    //   int userInput = 1;
    //   Pastry newPastry = new Pastry(userInput);
    //   int result = newPastry.returnPastryTotal();
    //   Assert.AreEqual(4, result);
    // }



  }
}