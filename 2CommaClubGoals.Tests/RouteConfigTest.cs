using System.Web.Routing;
// <copyright file="RouteConfigTest.cs">Copyright ©  2019</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoCommaClubGoals;

namespace TwoCommaClubGoals.Tests
{
    [TestClass]
    [PexClass(typeof(RouteConfig))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class RouteConfigTest
    {

        [PexMethod]
        public void RegisterRoutes(RouteCollection routes)
        {
            RouteConfig.RegisterRoutes(routes);
            // TODO: add assertions to method RouteConfigTest.RegisterRoutes(RouteCollection)
        }
    }
}
