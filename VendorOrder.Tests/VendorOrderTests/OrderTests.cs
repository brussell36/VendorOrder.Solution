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
      Order newOrder = new Order("test", "test", "test", "test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetValues_ReturnValues_String()
    {
      string title = "Ben's Brewery";
      string description = "Wants 30 loaves";
      string price = "$90";
      string date = "Friday Jul 24";
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetAll_ReturnOrders_List()
    {
      string title01 = "Ben's Brewery";
      string description01 = "Wants 30 loaves";
      string price01 = "$90";
      string date01 = "Friday July 24";
      string title02 = "Anna's Coffee";
      string description02 = "Needs 20 pastries";
      string price02 = "$30";
      string date02 = "Friday July 24";
      Order newOrder01 = new Order(title01, description01, price01, date01);
      Order newOrder02 = new Order(title02, description02, price02, date02);
      List<Order> newList = new List<Order> { newOrder01, newOrder02 };
      List<Order> answer = Order.GetAll();
      CollectionAssert.AreEqual(newList, answer);
    }
  }
}