using Microsoft.AspNetCore.Mvc;
using Wirecard.DeveloperPortal.Core;

namespace Wirecard.DeveloperPortal.WebSamples.Controllers
{
    public class BaseController : Controller
    {
        public Settings settings = new Settings()
        {
            UserCode = "",
            Pin = "",
            BaseUrl = "https://www.wirecard.com.tr/SGate/Gate",
            HashKey = ""
        };
    }
}
