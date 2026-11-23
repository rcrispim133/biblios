using Microsoft.AspNetCore.Mvc;

namespace Br.Bibliography.Web.Controllers.Base
{
    public abstract class Controller : ControllerBase, IController
    {
        [HttpOptions]
        public IActionResult HandleOptions()
        {
            Response.Headers.Append("Allow", "GET, POST, PUT, DELETE, OPTIONS");
            return Ok();
        }
    }
}
