// <copyright file="ConfigurationTest.cs">Copyright ©  2019</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoCommaClubGoals.Migrations;

namespace TwoCommaClubGoals.Migrations.Tests
{
    [TestClass]
    [PexClass(typeof(Configuration))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ConfigurationTest
    {

        [PexMethod]
        internal Configuration Constructor()
        {
            Configuration target = new Configuration();
            return target;
            // TODO: add assertions to method ConfigurationTest.Constructor()
        }
    }
}
