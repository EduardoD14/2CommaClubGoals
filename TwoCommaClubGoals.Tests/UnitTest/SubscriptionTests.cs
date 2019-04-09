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
using TwoCommaClubGoals.Entities;
using TwoCommaClubGoals.Abstract;
using Moq;

namespace TwoCommaClubGoals.Tests.UnitTest
{
    [TestClass]
    class SubscriptionTests
    {      
        //TO DO: Create Cart For Users to add lessons they want to purchase.
            [TestMethod]
            public void Adding_Courses_New_Line()
            { // Arrange - create some test lessons
                Lesson p1 = new Lesson { lessonID = 1, Name = "P1" };
                Lesson p2 = new Lesson { lessonID = 2, Name = "P2" };
                // Arrange - create a new cart 
                Cart target = new Cart();
                // Act 
                target.AddItem(p1, 1);
                target.AddItem(p2, 1);
                CartLine[] results = target.Lines.ToArray();
                // Assert 
                Assert.AreEqual(results.Length, 2);
                Assert.AreEqual(results[0].Lesson, p1);
                Assert.AreEqual(results[1].Lesson, p2);
            }

            [TestMethod]
            public void Can_Add_Quantity_For_Existing_Course_Lines()
            {
                // Arrange - create some test lessons
                Lesson p1 = new Lesson { lessonID = 1, Name = "P1" };
                Lesson p2 = new Lesson { lessonID = 2, Name = "P2" };
                // Arrange - create a new cart
                Cart target = new Cart();
                // Act 
                target.AddItem(p1, 1);
                target.AddItem(p2, 1);
                target.AddItem(p1, 10);
                CartLine[] results = target.Lines.OrderBy(c => c.Lesson.lessonID).ToArray();
                // Assert 
                Assert.AreEqual(results.Length, 2);
                Assert.AreEqual(results[0].Quantity, 11);
                Assert.AreEqual(results[1].Quantity, 1);
            }
            [TestMethod]
            public void Can_Remove_CourseLine()
            {
                // Arrange - create some test lessons 
                Lesson p1 = new Lesson { lessonID = 1, Name = "P1" };
                Lesson p2 = new Lesson { lessonID = 2, Name = "P2" };
                Lesson p3 = new Lesson { lessonID = 3, Name = "P3" };
                // Arrange - create a new cart
                Cart target = new Cart();
                // Arrange - add some lessons to the cart 
                target.AddItem(p1, 1);
                target.AddItem(p2, 3);
                target.AddItem(p3, 5);
                target.AddItem(p2, 1);
                // Act 
                target.RemoveLine(p2);
                // Assert 
                Assert.AreEqual(target.Lines.Where(c => c.Lesson == p2).Count(), 0);
                Assert.AreEqual(target.Lines.Count(), 2);
            }
            [TestMethod]
            public void Calculate_Cart_Total_For_Courses_Added()
            { // Arrange - create some test lessons
                Lesson p1 = new Lesson { lessonID = 1, Name = "P1", Price = 100 };
                Lesson p2 = new Lesson { lessonID = 2, Name = "P2", Price = 50 };
                // Arrange - create a new cart 
                Cart target = new Cart();
                // Act
                target.AddItem(p1, 1);
                target.AddItem(p2, 1);
                target.AddItem(p1, 3);
                decimal result = target.ComputeTotalValue();
                // Assert 
                Assert.AreEqual(result, 450M);
            }
            [TestMethod]
            public void Can_Clear_Couses_From_Cart()
            {
            // Arrange - create some test lessons
                Lesson p1 = new Lesson { lessonID = 1, Name = "P1", Price = 100 };
                Lesson p2 = new Lesson { lessonID = 2, Name = "P2", Price = 50 };
                // Arrange - create a new cart
                Cart target = new Cart();
                // Arrange - add some items
                target.AddItem(p1, 1);
                target.AddItem(p2, 1);
                // Act - reset the cart
                target.Clear();
                // Assert 
                Assert.AreEqual(target.Lines.Count(), 0);
            }
            [TestMethod]
            public void Can_Add_Course_To_Cart()
            {
                // Arrange - create the mock repository 
                Mock<ILessonRepository> mock = new Mock<ILessonRepository>();
                mock.Setup(m => m.Lessons).Returns(new Lesson[]
                {
                new Lesson {lessonID = 1, Name = "P1", Category = "Apples"},
                }.AsQueryable());
                // Arrange - create a Cart 
                Cart cart = new Cart();
                // Arrange - create the controller 
                CartController target = new CartController(mock.Object);
                // Act - add a lesson to the cart 
                target.AddToCart(cart, 1, null);
                // Assert 
                Assert.AreEqual(cart.Lines.Count(), 1);
                Assert.AreEqual(cart.Lines.ToArray()[0].Lesson.lessonID, 1);
            }
            [TestMethod]
            public void Adding_lesson_To_Cart_Goes_To_Cart_Screen()
            {
                // Arrange - create the mock repository 
                Mock<ILessonRepository> mock = new Mock<ILessonRepository>();
                mock.Setup(m => m.Lessons).Returns(new Lesson[]
                {
                new Lesson {lessonID = 1, Name = "P1", Category = "Apples"},
                }.AsQueryable());
                // Arrange - create a Cart 
                Cart cart = new Cart();
                // Arrange - create the controller
                CartController target = new CartController(mock.Object);
                // Act - add a lesson to the cart 
                RedirectToRouteResult result = target.AddToCart(cart, 2, "myUrl");
                // Assert 
                Assert.AreEqual(result.RouteValues["action"], "Index");
                Assert.AreEqual(result.RouteValues["returnUrl"], "myUrl");
            }
            [TestMethod]
            public void Can_View_Cart_Contents()
            {
                // Arrange - create a Cart 
                Cart cart = new Cart();
                // Arrange - create the controller
                CartController target = new CartController(null);
                // Act - call the Index action method
                CartIndexViewModel result
                    = (CartIndexViewModel)target.Index(cart, "myUrl").ViewData.Model;
                // Assert 
                Assert.AreSame(result.Cart, cart);
                Assert.AreEqual(result.ReturnUrl, "myUrl");
            }
            [TestMethod]
            public void Cannot_Checkout_Empty_Cart()
            { // Arrange - create a mock order processor 
                Mock<IOrderProcessor> mock = new Mock<IOrderProcessor>();
                // Arrange - create an empty cart
                Cart cart = new Cart();
                // Arrange - create an instance of the controller
                CartController target = new CartController(null, mock.Object);
                // Act 
                ViewResult result = target.Checkout(cart);
                // Assert - check that the order hasn't been passed on to the processor
                mock.Verify(m => m.ProcessOrder(It.IsAny<Cart>()),
                    Times.Never());
                // Assert - check that the method is returning the default view 
                Assert.AreEqual("", result.ViewName);
                // Assert - check that I am passing an invalid model to the view 
                Assert.AreEqual(false, result.ViewData.ModelState.IsValid);
            }
          
            [TestMethod]
            public void Can_Checkout_And_Submit_Order()
            {
                // Arrange - create a mock order processor 
                Mock<IOrderProcessor> mock = new Mock<IOrderProcessor>();
                // Arrange - create a cart with an item
                Cart cart = new Cart(); cart.AddItem(new Lesson(), 1);
                // Arrange - create an instance of the controller
                CartController target = new CartController(null, mock.Object);
                // Act - try to checkout
                ViewResult result = target.Checkout(cart);
                // Assert - check that the order has been passed on to the processor 
                mock.Verify(m => m.ProcessOrder(It.IsAny<Cart>()),
                    Times.Once());
                // Assert - check that the method is returning the Completed view 
                Assert.AreEqual("Completed", result.ViewName);
                // Assert - check that I am passing a valid model to the view 
                Assert.AreEqual(true, result.ViewData.ModelState.IsValid);
            }

        }
}
