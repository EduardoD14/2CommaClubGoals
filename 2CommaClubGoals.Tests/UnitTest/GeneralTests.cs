using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoCommaClubGoals;
using TwoCommaClubGoals.Controllers;
using TwoCommaClubGoals.HtmlHelpers;
using TwoCommaClubGoals.Models;

namespace TwoCommaClubGoals.Tests.Controllers
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
            Assert.AreEqual("Who are we?", result.ViewBag.Message);
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
        public void Register()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Register() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Credit()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Credit() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Investing()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Credit() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Savings()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Credit() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Page_Links_Generation()
        {
            // Arrange - define an HTML helper in order to apply the extension method
            HtmlHelper myHelper = null;
            // Arrange - create PagingInfo data 
            Paging paging = new Paging
            {
                CurrentPage = 5,
                TotalLessons = 42,
                LessonsPerPage = 10
            };
            // Arrange - set up the delegate using a lambda expression
            Func<int, string> pageUrlDelegate = i => "Page" + i;
            // Act
            MvcHtmlString result = myHelper.PageLinks(paging, pageUrlDelegate);
            // Assert 
            Assert.AreEqual
            ( @"<a class=""btn btn-default"" href=""Page1"">1</a>"
            + @"<a class=""btn btn-default"" href=""Page2"">2</a>"
            + @"<a class=""btn btn-default"" href=""Page3"">3</a>"
            + @"<a class=""btn btn-default"" href=""Page4"">4</a>"
            + @"<a class=""btn btn-default btn-primary selected"" href=""Page5"">5</a>",
            result.ToString());
        }

    }
}
