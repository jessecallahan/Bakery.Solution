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
    public void PastryTotal_ReturnsPastryTotal_Int()
    {
      int userInput = 1;
      Pastry newPastry = new Pastry(userInput);
      int result = newPastry.Amount;
      Assert.AreEqual(userInput, result);
    }



  }
}