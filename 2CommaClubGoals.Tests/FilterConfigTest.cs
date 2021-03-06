using System.Web.Mvc;
// <copyright file="FilterConfigTest.cs">Copyright ©  2019</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoCommaClubGoals;

namespace TwoCommaClubGoals.Tests
{
    [TestClass]
    [PexClass(typeof(FilterConfig))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class FilterConfigTest
    {

        [PexMethod]
        public void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            FilterConfig.RegisterGlobalFilters(filters);
            // TODO: add assertions to method FilterConfigTest.RegisterGlobalFilters(GlobalFilterCollection)
        }
    }
}
