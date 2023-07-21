using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Pierres.Models;

namespace Pierres.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet("/orders")]
        public ActionResult Index()
        {
            List<Order> allOrders = Order.GetAll();
            return View(allOrders);
        }

        [HttpGet("/vendors/{vendorId}/orders/new")]
        public ActionResult New(int VenderId)
        {
            Vendor vender = Vendor.Find(VenderId);
            return View(vender);
        }
    }
}