namespace CalculationLibrary1
{
    public class Calculations
    
   
        {
            public static double Addition(double a, double b)
            {
                return a + b;
            }
            public static double Subtraction(double a, double b)
            {
                return a - b;
            }
            public static double Multiplication(double a, double b)
            {
                return a * b;
            }
            public static double Dividation(double a, double b)
            {
                if (b != 0)
                {
                    return a / b;
                }
                else
                {
                    throw new DivideByZeroException();

                }
            }
        }
    

}
}