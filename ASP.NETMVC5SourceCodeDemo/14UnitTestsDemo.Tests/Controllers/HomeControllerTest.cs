﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _14UnitTestsDemo;
using _14UnitTestsDemo.Controllers;
using Moq;

namespace _14UnitTestsDemo.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void SendMeSomeWhereElseIssuesRedirect()
        {
            //var mockContent = new Mock<ControllerContext>();
            //mockContent.Setup(c=>c.HttpContext.Response.Redirect("~/home/index"));
            //var controller = new HomeController();
            //controller.ControllerContext = mockContent.Object;
            //controller.SendMeSomeWhereElse();
            //mockContent.Verify();

            var controller = new HomeController();
            var result = controller.SendMeSomeWhereElse();
            Assert.AreEqual("~/home/index",result.Url);
        }
    }
}
