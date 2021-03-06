// <copyright file="HomeControllerTest.cs">Copyright ©  2015</copyright>
using System;
using System.Web.Mvc;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VSwithGitHub.Controllers;

namespace VSwithGitHub.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for HomeController</summary>
    [PexClass(typeof(HomeController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class HomeControllerTest
    {
        /// <summary>Test stub for Contact()</summary>
        [PexMethod]
        public ActionResult ContactTest([PexAssumeUnderTest]HomeController target)
        {
            ActionResult result = target.Contact();
            return result;
            // TODO: add assertions to method HomeControllerTest.ContactTest(HomeController)
        }
    }
}
