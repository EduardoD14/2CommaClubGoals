using System.Web.Mvc;
// <copyright file="CoursesControllerTest.cs">Copyright ©  2019</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoCommaClubGoals.Controllers;

namespace TwoCommaClubGoals.Controllers.Tests
{
    [TestClass]
    [PexClass(typeof(CoursesController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CoursesControllerTest
    {

        [PexMethod]
        public ViewResult Savings([PexAssumeUnderTest]CoursesController target)
        {
            ViewResult result = target.Savings();
            return result;
            // TODO: add assertions to method CoursesControllerTest.Savings(CoursesController)
        }
    }
}
