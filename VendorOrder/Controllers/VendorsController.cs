using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;

namespace VendorOrder.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allCategories = Category.GetAll();
      return View(allCategories);
    }
  }
}