using Microsoft.AspNetCore.Antiforgery;
using ASPNetCoreAngularApp2.Controllers;

namespace ASPNetCoreAngularApp2.Web.Host.Controllers
{
    public class AntiForgeryController : ASPNetCoreAngularApp2ControllerBase
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
