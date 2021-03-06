// <copyright file="PagingTest.cs">Copyright ©  2019</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoCommaClubGoals.Models;

namespace TwoCommaClubGoals.Models.Tests
{
    [TestClass]
    [PexClass(typeof(Paging))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PagingTest
    {

        [PexMethod]
        public int TotalPagesGet([PexAssumeUnderTest]Paging target)
        {
            int result = target.TotalPages;
            return result;
            // TODO: add assertions to method PagingTest.TotalPagesGet(Paging)
        }
    }
}
