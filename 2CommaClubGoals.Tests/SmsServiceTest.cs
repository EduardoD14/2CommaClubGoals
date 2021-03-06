using Microsoft.AspNet.Identity;
using System.Threading.Tasks;
// <copyright file="SmsServiceTest.cs">Copyright ©  2019</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoCommaClubGoals;

namespace TwoCommaClubGoals.Tests
{
    [TestClass]
    [PexClass(typeof(SmsService))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SmsServiceTest
    {

        [PexMethod]
        public Task SendAsync([PexAssumeUnderTest]SmsService target, IdentityMessage message)
        {
            Task result = target.SendAsync(message);
            return result;
            // TODO: add assertions to method SmsServiceTest.SendAsync(SmsService, IdentityMessage)
        }
    }
}
