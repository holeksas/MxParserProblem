//using Newtonsoft.Json.Linq;
using org.mariuszgromada.math.mxparser;
using System;

namespace Logic
{
    public class Class1
    {
        public double Calc(string expr)
        {
            var ex = new Expression(expr);
            return ex.calculate();
        }
    }
}
