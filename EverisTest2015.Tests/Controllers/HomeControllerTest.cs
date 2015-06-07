using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EverisTest2015;
using EverisTest2015.Controllers;

namespace EverisTest2015.Tests.Controllers
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
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
