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
      string title01 = "cafe";
      string title02 = "corner store";
      string description01 = "suburbs";
      string description02 = "downtown";
      Vendor newVendor1 = new Vendor(title01, description01);
      Vendor newVendor2 = new Vendor(title02, description02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string title01 = "cafe";
      string title02 = "corner store";
      string description01 = "suburbs";
      string description02 = "downtown";
      Vendor newVendor1 = new Vendor(title01, description01);
      Vendor newVendor2 = new Vendor(title02, description02);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }
  }
}