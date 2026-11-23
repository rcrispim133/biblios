using Microsoft.AspNetCore.Mvc;

namespace Br.Bibliography.Web.Controllers.Base
{
    public interface IController
    {
        IActionResult HandleOptions();
    }
}
