using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._1._2
{
    internal class Calculator : ICalculate
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Subtract(double x, double y)
        {
            return x - y;
        }
        public double Multiply(double x, double y)
        {
            return x * y;
        }
        public double Divide(double x, double y)
        {
            return x / y;
        }
    }
}
