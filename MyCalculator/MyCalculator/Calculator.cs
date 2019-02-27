using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Mul(double a, double b)
        {
            return a * b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public double Div(double a, double b)
        {
            return a / b;
        }

        public double Mod(double a, double b)
        {
            return a % b;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }

        public double Sine(double a)
        {
            return Math.Sin(a);
        }

        public double Cos(double a)
        {
            return Math.Cos(a);
        }

        public double Tan(double a)
        {
            return Math.Tan(a);
        }
    }
}
