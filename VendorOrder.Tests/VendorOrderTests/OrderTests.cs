using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetName_ReturnName_String()
    {
      string name = "Ben's Bakery";
      Vendor newVendor = new Vendor(name);
      string answer = newVendor.Name;
      Assert.AreEqual(name, answer);
    }
  }
}