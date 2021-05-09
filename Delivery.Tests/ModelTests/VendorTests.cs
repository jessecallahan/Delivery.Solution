using Microsoft.VisualStudio.TestTools.UnitTesting;
using Delivery.Models;
using System.Collections.Generic;
using System;

namespace Delivery.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOVendor()
    {
      Vendor newVendor = new Vendor("test Vendor Title", "Test Description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "cafe";
      string name02 = "corner store";
      string description01 = "suburbs";
      string description02 = "downtown";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "cafe";
      string name02 = "corner store";
      string description01 = "suburbs";
      string description02 = "downtown";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string orderTitle = "bread";
      string orderDescription = "sourdough";
      int orderPrice = 10;
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice);
      List<Order> newList = new List<Order> { newOrder };
      string vendorName = "cafe";
      string vendorDescription = "downtown";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }
  }
}