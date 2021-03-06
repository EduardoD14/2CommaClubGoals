using Microsoft.AspNet.Identity;
using System.Threading.Tasks;
// <copyright file="EmailServiceTest.cs">Copyright ©  2019</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoCommaClubGoals;

namespace TwoCommaClubGoals.Tests
{
    [TestClass]
    [PexClass(typeof(EmailService))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class EmailServiceTest
    {

        [PexMethod]
        public Task SendAsync([PexAssumeUnderTest]EmailService target, IdentityMessage message)
        {
            Task result = target.SendAsync(message);
            return result;
            // TODO: add assertions to method EmailServiceTest.SendAsync(EmailService, IdentityMessage)
        }
    }
}
