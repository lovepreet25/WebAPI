using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace WebAPI.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculationController: ControllerBase
    {
    }
}

    public class CalculatorApi : ControllerBase
    {
    [HttpGet]
    // method for addition
    public double Addition(double a, double b)
    {
        return CalculationLibrary1.Calculations.Addition(a, b);

    }
    [HttpGet]
    //method for subtracttionn
    public double Subtraction(double a, double b)
    {
        return CalculationLibrary1.Calculations.Subtraction(a, b);
    }
    [HttpGet]
    //method multiplication of the numbers
    public double Multiplication(double a, double b)
    {
        return CalculationLibrary1.Calculations.Multiplication(a, b);
    }
    //method fot dividing the numbers
    [HttpGet]
    public double dividation(double a, double b)
    {
        double result = 0;
        try
        {
            result = CalculationLibrary1.Calculations.Dividation(a, b);
        }
        catch (DivideByZeroException)
        {
            Response.StatusCode = 400;
        }
        return result;
    }
}



