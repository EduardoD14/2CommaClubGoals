using Microsoft.AspNet.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
// <copyright file="ApplicationUserTest.cs">Copyright ©  2019</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoCommaClubGoals.Models;

namespace TwoCommaClubGoals.Models.Tests
{
    [TestClass]
    [PexClass(typeof(ApplicationUser))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ApplicationUserTest
    {

        [PexMethod]
        public Task<ClaimsIdentity> GenerateUserIdentityAsync([PexAssumeUnderTest]ApplicationUser target, UserManager<ApplicationUser> manager)
        {
            Task<ClaimsIdentity> result = target.GenerateUserIdentityAsync(manager);
            return result;
            // TODO: add assertions to method ApplicationUserTest.GenerateUserIdentityAsync(ApplicationUser, UserManager`1<ApplicationUser>)
        }
    }
}
