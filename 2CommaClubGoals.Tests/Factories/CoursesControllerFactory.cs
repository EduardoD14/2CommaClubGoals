using System.Web.Mvc;
using TwoCommaClubGoals.Controllers;
// <copyright file="CoursesControllerFactory.cs">Copyright ©  2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace TwoCommaClubGoals.Controllers
{
    /// <summary>A factory for TwoCommaClubGoals.Controllers.CoursesController instances</summary>
    public static partial class CoursesControllerFactory
    {
        /// <summary>A factory for TwoCommaClubGoals.Controllers.CoursesController instances</summary>
        [PexFactoryMethod(typeof(CoursesController))]
        public static CoursesController Create(
            IDependencyResolver value_iDependencyResolver,
            IActionInvoker value_iActionInvoker,
            ITempDataProvider value_iTempDataProvider,
            UrlHelper value_urlHelper,
            ViewEngineCollection value_viewEngineCollection,
            ControllerContext value_controllerContext,
            TempDataDictionary value_tempDataDictionary,
            bool value_b,
            IValueProvider value_iValueProvider,
            ViewDataDictionary value_viewDataDictionary
        )
        {
            CoursesController coursesController = new CoursesController();
            ((Controller)coursesController).Resolver = value_iDependencyResolver;
            ((Controller)coursesController).ActionInvoker = value_iActionInvoker;
            ((Controller)coursesController).TempDataProvider = value_iTempDataProvider;
            ((Controller)coursesController).Url = value_urlHelper;
            ((Controller)coursesController).ViewEngineCollection =
              value_viewEngineCollection;
            ((ControllerBase)coursesController).ControllerContext = value_controllerContext;
            ((ControllerBase)coursesController).TempData = value_tempDataDictionary;
            ((ControllerBase)coursesController).ValidateRequest = value_b;
            ((ControllerBase)coursesController).ValueProvider = value_iValueProvider;
            ((ControllerBase)coursesController).ViewData = value_viewDataDictionary;
            return coursesController;

            // TODO: Edit factory method of CoursesController
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
