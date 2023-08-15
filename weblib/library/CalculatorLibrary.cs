using System;
using NCalc;

namespace library
{
    public class Calculator
    {
        public int Calculate(string expression)
        {
            try
            {
                Expression ncalcExpression = new Expression(expression);
                object result = ncalcExpression.Evaluate();
                return Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Invalid expression: " + ex.Message);
            }
        }
    }
}
