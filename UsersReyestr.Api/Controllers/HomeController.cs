using Microsoft.AspNetCore.Mvc;

namespace UsersReyestr.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        public string Get()=>
             "Hello";
    }
}
