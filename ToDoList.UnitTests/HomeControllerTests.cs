using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using ToDoList.Web.Controllers;

namespace ToDoList.UnitTests
{
    public class Tests
    {
        private HomeController homeController;
        private Mock<ILogger<HomeController>> mockLogger;

        [SetUp]
        public void Setup()
        {
            mockLogger = new Mock<ILogger<HomeController>>();

            homeController = new HomeController(mockLogger.Object);
        }

        [Test]
        public void Index_loads_expected_view()
        {
            var result = homeController.Index() as ViewResult;

            Assert.AreEqual("Index", result.ViewName);
        }
    }
}