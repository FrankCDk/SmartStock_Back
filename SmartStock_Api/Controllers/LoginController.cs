using Microsoft.AspNetCore.Mvc;

namespace SmartStock_Api.Controllers
{
    [ApiController]
    [Route("api/v1/login/[action]")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
