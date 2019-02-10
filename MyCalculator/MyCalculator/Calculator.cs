﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Div(int a, int b)
        {
            return a / b;
        }

        public int Mod(int a, int b)
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
    }
}
