using Microsoft.VisualStudio.TestTools.UnitTesting;
using Delivery.Models;
using System.Collections.Generic;
using System;

namespace Delivery.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test Order Title", 100, "Test Description");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}