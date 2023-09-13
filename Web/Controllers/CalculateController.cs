using Microsoft.AspNetCore.Mvc;
using Domain;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculateController : ControllerBase
    {

        [HttpGet("Add/{left}/{right}")]
        public int Add(int left, int right)
        {
            return new Calculator().Sum(left, right);
        }

        [HttpGet("Diff/{left}/{right}")]
        public int Subtract(int left, int right)
        {
            return new Calculator().Diff(left, right);
        }

        [HttpGet("Div/{left}/{right}")]
        public int Divide(int left, int right)
        {
            return new Calculator().Div(left, right);
        }

        [HttpGet("Multiply/{left}/{right}")]
        public int Multiply(int left, int right)
        {
            return new Calculator().Multiply(left, right);
        }
    }
}
