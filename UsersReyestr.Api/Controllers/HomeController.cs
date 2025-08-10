using Microsoft.AspNetCore.Mvc;

namespace UsersReyestr.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public string Get()=>
             "Hello";
    }
}
