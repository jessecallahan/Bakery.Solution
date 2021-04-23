// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using Bakery.Models;
// using System.Collections.Generic;
// using System;

// namespace Bakery.Tests
// {
//   [TestClass]
//   public class BreadTests
//   {

//     [TestMethod]
//     public void ItemConstructor_CreatesInstanceOfItem_Item()
//     {
//       Item newItem = new Item("test");
//       Assert.AreEqual(typeof(Item), newItem.GetType());
//     }

//     [TestMethod]
//     public void GetDescription_ReturnsDescription_String()
//     {
//       //Arrange 
//       string description = "Walk the dog.";
//       Item newItem = new Item(description);
//       //Act
//       string result = newItem.Description;
//       //Assert
//       Assert.AreEqual(description, result);
//     }
//   }
// }