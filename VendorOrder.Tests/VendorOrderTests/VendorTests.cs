using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstancesOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnName_String()
    {
      string name = "Ben's Bakery";
      string description = "Located in North Portland";
      Vendor newVendor = new Vendor(name, description);
      string answer = newVendor.Name;
      Assert.AreEqual(name, answer);
    }

    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string name = "Ben's Bakery";
      string description = "Located in North Portland";
      Vendor newVendor = new Vendor(name, description);
      string answer = newVendor.Description;
      Assert.AreEqual(description, answer);
    }

    [TestMethod]
    public void GetId_ReturnVendorId_Int()
    {
      string name = "Ben's Bakery";
      string description = "Located in North Portland";
      Vendor newVendor = new Vendor(name, description);
      int answer = newVendor.Id;
      Assert.AreEqual(1, answer);
    }

    [TestMethod]
    public void GetAll_ReturnAllVendorObjects_VendorList()
    {
      string name01 = "Ben's Brewery";
      string description01 = "Located in North Portland";
      string name02 = "Anna's Coffee";
      string description02 = "Located in St. John's";
      Vendor newVendor01 = new Vendor(name01, description01);
      Vendor newVendor02 = new Vendor(name02, description02);
      List<Vendor> newList = new List<Vendor> {newVendor01, newVendor02};
      List<Vendor> answer = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, answer);
    }
  }
}
