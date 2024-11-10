using Microsoft.AspNetCore.Mvc;

namespace SmartStock_Api.Controllers
{

    [ApiController]
    [Route("/api/v1/product/[action]")]
    public class ProductController : Controller
    {

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok();
        }
    }
}
