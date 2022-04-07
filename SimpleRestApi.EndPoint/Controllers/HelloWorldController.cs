using Microsoft.AspNetCore.Mvc;

namespace SimpleRestApi.EndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello, World.";
        }
    }
}
