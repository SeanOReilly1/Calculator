﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    class RunProgram
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            int n1, n2;
            string again = "";
            Input(c, out n1, out n2, out again);
        }

        public static void Input(Calculator c, out int n1, out int n2, out string again)
        {
            do
            {
                Console.WriteLine("This is a Calculator, enter number, action, number ");
                Console.WriteLine("Available Actions : ");
                Console.WriteLine("+ - * / % pow ");
                n1 = int.Parse(Console.ReadLine());
                string action = (Console.ReadLine());
                if(action.ToUpper() != "SQRT")
                {
                    n2 = int.Parse(Console.ReadLine());
                }

                else
                {
                    n2 = 0;
                }
                

                if (action == "+")
                {
                    Console.WriteLine(c.Add(n1, n2));
                }

                else if (action == "-")
                {
                    Console.WriteLine(c.Sub(n1, n2));
                }

                else if (action == "*")
                {
                    Console.WriteLine(c.Mul(n1, n2));
                }

                else if (action == "/")
                {
                    Console.WriteLine(c.Div(n1, n2));
                }

                else if (action == "%")
                {
                    Console.WriteLine(c.Mod(n1, n2));
                }

                else if (action.ToUpper() == "POW")
                {
                    Console.WriteLine(c.Power(n1, n2));
                }

                else if (action.ToUpper() == "SQRT")
                {
                    Console.WriteLine(c.Sqrt(n1));
                }

                else
                {
                    Console.WriteLine("Invalid Entry");
                }
                
                Console.WriteLine("Continue, Yes or No? ");
                again = Console.ReadLine();


            } while (again.ToUpper() == "YES");
        }
    }
}
