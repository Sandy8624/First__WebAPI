using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace First__WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        // api/calculator/add?x=10&y=20
        [HttpGet("demo/add")]
        public int Add(int x, int y)
        {
            return x + y + 20000;
        }
    }
}
