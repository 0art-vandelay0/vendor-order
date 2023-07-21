using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierres.Models;
using System.Collections.Generic;
using System;

namespace Pierres.Tests.ModelTests
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
            Order newOrder = new Order("Test Title", "Test description", 25, "07-21-2023");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetProperties_ReturnsOrderProperies_Order()
        {
            string title = "Test Title";
            string description = "Test description";
            int price = 150;
            string date = "07-21-2023";
            Order newOrder = new Order(title, description, price, date);
            string titleResult = newOrder.Title;
            string descrptResult = newOrder.Description;
            int priceResult = newOrder.Price;
            string dateResult = newOrder.Date;
            Assert.AreEqual(title, titleResult);
            Assert.AreEqual(description, descrptResult);
            Assert.AreEqual(price, priceResult);
            Assert.AreEqual(date, dateResult);
        }

        [TestMethod]
        public void SetTitle_SetsTitle_String()
        {
            string title = "Test Title";
            string description = "Test description";
            int price = 150;
            string date = "07-21-2023";
            Order newOrder = new Order(title, description, price, date);
            string newTitle = "Updated Title";
            newOrder.Title = newTitle;
            string result = newOrder.Title;
            Assert.AreEqual(newTitle, result);
        }

        [TestMethod]
        public void SetDescrption_SetsDescription_String()
        {
            string title = "Test Title";
            string description = "Test description";
            int price = 150;
            string date = "07-21-2023";
            Order newOrder = new Order(title, description, price, date);
            string newDescription = "Updated Description";
            newOrder.Description = newDescription;
            string result = newOrder.Description;
            Assert.AreEqual(newDescription, result);
        }

        [TestMethod]
        public void SetPrice_SetsPrice_String()
        {
            string title = "Test Title";
            string description = "Test description";
            int price = 150;
            string date = "07-21-2023";
            Order newOrder = new Order(title, description, price, date);
            int newPrice = 100;
            newOrder.Price = newPrice;
            int result = newOrder.Price;
            Assert.AreEqual(newPrice, result);
        }

        [TestMethod]
        public void SetDate_SetsDate_String()
        {
            string title = "Test Title";
            string description = "Test description";
            int price = 150;
            string date = "07-21-2023";
            Order newOrder = new Order(title, description, price, date);
            string newDate = "07-30-2023";
            newOrder.Date = newDate;
            string result = newOrder.Date;
            Assert.AreEqual(newDate, result);
        }
    }
}