using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetAmount_ReturnsBreadAmount_Int()
    {
      int userInput = 1;
      Bread newBread = new Bread(userInput);
      int result = newBread.Amount;
      Assert.AreEqual(userInput, result);
    }

    [TestMethod]
    public void ReturnBreadTotalCost_ReturnsBreadTotalCostTest1_Int()
    {
      int userInput = 0;
      Bread newBread = new Bread(userInput);
      int result = newBread.returnBreadTotalCost();
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void ReturnBreadTotalCost_ReturnsBreadTotalCostTest2_Int()
    {
      int userInput = 1;
      Bread newBread = new Bread(userInput);
      int result = newBread.returnBreadTotalCost();
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void ReturnBreadTotalCost_ReturnsBreadTotalCostTest3_Int()
    {
      int userInput = 2;
      Bread newBread = new Bread(userInput);
      int result = newBread.returnBreadTotalCost();
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void ReturnBreadTotalCost_ReturnsBreadTotalCostTest4_Int()
    {
      int userInput = 3;
      Bread newBread = new Bread(userInput);
      int result = newBread.returnBreadTotalCost();
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void ReturnBreadTotalCost_ReturnsBreadTotalCostTest5_Int()
    {
      int userInput = 4;
      Bread newBread = new Bread(userInput);
      int result = newBread.returnBreadTotalCost();
      Assert.AreEqual(15, result);
    }

    [TestMethod]
    public void ReturnAmountofBread_ReturnsBreadDetailsTest1_String()
    {
      int userInput = 1;
      Bread newBread = new Bread(userInput);
      string result = newBread.returnAmountofBread();
      Assert.AreEqual("1 loaf of Bread", result);
    }
  }
}