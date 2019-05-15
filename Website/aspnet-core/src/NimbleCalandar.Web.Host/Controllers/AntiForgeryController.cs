using Microsoft.AspNetCore.Antiforgery;
using NimbleCalandar.Controllers;

namespace NimbleCalandar.Web.Host.Controllers
{
    public class AntiForgeryController : NimbleCalandarControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
