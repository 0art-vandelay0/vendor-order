using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierres.Models;
using System.Collections.Generic;
using System;

namespace Pierres.Tests.ModelTests
{
    [TestClass]
    public class VendorTests : IDisposable
    {
        public void Dispose()
        {
            Vendor.ClearAll();
        }

        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("test vendor", "test description");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void VendorConstructor_ReturnsProperties_String()
        {
            string name = "Test Vendor";
            string description = "Test Description";
            Vendor newVendor = new Vendor(name, description);
            string nameResult = newVendor.Name;
            string descResult = newVendor.Description;
            Assert.AreEqual(name, nameResult);
            Assert.AreEqual(description, descResult);
        }

        [TestMethod]
        public void GetId_ReturnsVendorId_Int()
        {
            string name = "Test Category";
            string description = "Test Description";
            Vendor newVendor = new Vendor(name, description);
            int result = newVendor.Id;
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetAll_ReturnsAllVendorObjects_VendorList()
        {
            string name01 = "Suzie's Cafe";
            string name02 = "Humphrey's Bagels";
            string description01 = "Weekly";
            string description02 = "Bi weekly";
            Vendor newVendor1 = new Vendor(name01, description01);
            Vendor newVendor2 = new Vendor(name02, description02);
            List<Vendor> newVendorList = new List<Vendor> { newVendor1, newVendor2 };

            List<Vendor> result = Vendor.GetAll();
            CollectionAssert.AreEqual(newVendorList, result);
        }
    }
}