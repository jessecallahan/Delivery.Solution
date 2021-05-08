// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using Delivery.Models;
// using System.Collections.Generic;
// using System;

// namespace Delivery.Tests
// {
//   [TestClass]
//   public class OrderTests : IDisposable
//   {

//     public void Dispose()
//     {
//       Order.ClearAll();
//     }

//     [TestMethod]
//     public void OrderConstructor_CreatesInstanceOfOrder_Order()
//     {
//       Order newOrder = new Order("test Order Title", "Test Description", 100);
//       Assert.AreEqual(typeof(Order), newOrder.GetType());
//     }

//     [TestMethod]
//     public void GetAll_ReturnsAllOrderObjects_OrderList()
//     {
//       string title01 = "cafe";
//       string title02 = "corner store";
//       int price01 = 100;
//       int price02 = 200;
//       string description01 = "suburbs";
//       string description02 = "downtown";
//       Order newOrder1 = new Order(title01, description01, price01);
//       Order newOrder2 = new Order(title02, description02, price02);
//       List<Order> newList = new List<Order> { newOrder1, newOrder2 };

//       List<Order> result = Order.GetAll();

//       CollectionAssert.AreEqual(newList, result);
//     }

//     [TestMethod]
//     public void Find_ReturnsCorrectOrder_Order()
//     {
//       string title01 = "cafe";
//       string title02 = "corner store";
//       int price01 = 100;
//       int price02 = 200;
//       string description01 = "suburbs";
//       string description02 = "downtown";
//       Order newOrder1 = new Order(title01, description01, price01);
//       Order newOrder2 = new Order(title02, description02, price02);

//       Order result = Order.Find(2);

//       Assert.AreEqual(newOrder2, result);
//     }
//   }
// }