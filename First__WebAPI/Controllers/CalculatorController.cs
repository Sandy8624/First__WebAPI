using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace First__WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // api/calculator/add?x=10&y=20
       [HttpGet("calculator/add")] 
        public int Add (int x,int y)
        {
            return x + y;
        }
        [HttpGet("calculator/sum")]
        public int Sum(int x, int y)
        {
            return x + y + 500;
        }
        // api/calculator/subtract?x=10&y=20
        [HttpPost]
        public int subtract (int x, int y)
        {
            return x - y;
        }
        // api/calculator/multiply?x=10&y=20
        [HttpPut]
        public int Mutiply(int x, int y)
        {
            return x * y;
        }
        // api/calculator/Divide?x=50&y=10
        [HttpDelete]
        public int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
