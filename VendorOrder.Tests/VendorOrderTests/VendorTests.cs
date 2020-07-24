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
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnName_String()
    {
      string name = "Ben's Bakery";
      Vendor newVendor = new Vendor(name);
      string answer = newVendor.Name;
      Assert.AreEqual(name, answer);
    }

    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string description = "Located in North Portland";
      Vendor newVendor = new Vendor(description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result)
    }
  }
}
