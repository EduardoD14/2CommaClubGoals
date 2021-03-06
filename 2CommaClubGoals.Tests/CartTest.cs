// <copyright file="CartTest.cs">Copyright ©  2019</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoCommaClubGoals.Entities;

namespace TwoCommaClubGoals.Entities.Tests
{
    [TestClass]
    [PexClass(typeof(Cart))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CartTest
    {

        [PexMethod]
        public void RemoveLine([PexAssumeUnderTest]Cart target, Lesson Lesson)
        {
            target.RemoveLine(Lesson);
            // TODO: add assertions to method CartTest.RemoveLine(Cart, Lesson)
        }
    }
}
