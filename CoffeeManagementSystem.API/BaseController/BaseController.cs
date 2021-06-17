using CoffeeManagementSystem.API.Functions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeManagementSystem.API.BaseController
{
    /// <summary>
    /// BaseController.
    /// </summary>
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [Authorize]
    public abstract class BaseController : Controller
    {
        /// <summary>
        /// HelperConstants.
        /// </summary>
        protected HelperConstantsModel HelperConstants;
    }
}
