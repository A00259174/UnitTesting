using Microsoft.AspNetCore.Mvc;
using CalculatorLibrary;

namespace MyProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly Calculator _calculator;

        public CalculatorController(Calculator calculator)
        {
            _calculator = calculator;
        }

        [HttpGet("Addition")]
        public ActionResult<decimal> Add(decimal num1, decimal num2)
        {
            return _calculator.Add(num1, num2);
        }

        [HttpGet("Subtraction")]
        public ActionResult<decimal> Subtract(decimal num1, decimal num2)
        {
            return _calculator.Subtract(num1, num2);
        }

        [HttpGet("Multiplication")]
        public ActionResult<decimal> Multiply(decimal num1, decimal num2)
        {
            return _calculator.Multiply(num1, num2);
        }

        [HttpGet("Division")]
        public ActionResult<decimal> Divide(decimal num1, decimal num2)
        {
            if (num2 == 0)
            {
                return BadRequest("Cannot divide by zero");
            }
            return _calculator.Divide(num1, num2);
        }

        [HttpGet("Modulo")]
        public ActionResult<decimal> Modulo(decimal num1, decimal num2)
        {
            if (num2 == 0)
            {
                return BadRequest("Cannot find modulo by zero");
            }
            return _calculator.Modulo(num1, num2);
        }
    }
}
