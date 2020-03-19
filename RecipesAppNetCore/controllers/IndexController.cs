using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAppNetCore.controllers
{
    /// <summary>
    /// Index controller
    /// Provides welcome text and health endpoint
    /// </summary>
    [ApiController]
    public class IndexController : ControllerBase
    {
        /// <summary>
        /// Welcome Index text. This endpoint avoids a "Not found" error when first opening
        /// </summary>
        /// <returns>Welcome text</returns>
        [HttpGet]
        [Route("/")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<string> Index()
        {
            return Ok("Welcome to RecipesAppNetCore application");
        }

        /// <summary>
        /// Health endpoint simply returns an Ok (200). Just for debugging and controller health verification
        /// </summary>
        /// <returns>Void. Simply a 200 statuc code</returns>
        [HttpGet]
        [Route("/health")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Health()
        {
            return Ok();
        }
    }
}
