using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pierres.Models;

namespace Pierres.Controllers
{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> allVendors = Vendor.GetAll();
            return View(allVendors);
        }

        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }
    }
}