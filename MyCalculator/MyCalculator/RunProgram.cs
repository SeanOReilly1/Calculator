﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MyCalculator
{
    class RunProgram
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            // Calculator c2 = new Calculator();
            // Console.WriteLine(Math.Round(c2.Tan(20), 4));
            double n1 = 0, n2;
            string again = "";
            bool keep = true;
            

            do
            {
                do
                {
                    keep = true;
                try
                {

                    Console.WriteLine("This is a Calculator, enter number, action, number ");
                    Console.WriteLine("Available Actions : ");
                    Console.WriteLine("+ - * / % pow sqrt sine cos tan ");

                    n1 = double.Parse(Console.ReadLine());

               
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    keep = false;
                    
                }

                   


                } while (keep == false);

                string action = (Console.ReadLine());



                if ((action.ToUpper() != "SQRT") &&
                    (action.ToUpper() != "SINE") &&
                    (action.ToUpper() != "COS") &&
                    (action.ToUpper() != "TAN"))
                {
                    n2 = int.Parse(Console.ReadLine());
                }

                else
                {
                    n2 = 0;
                }


                if (action == "+")
                {
                    Console.WriteLine("Answer is " + c.Add(n1, n2));
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

                else if (action.ToUpper() == "SINE")
                {
                    Console.WriteLine(c.Sine(n1));
                }

                else if (action.ToUpper() == "COS")
                {
                    Console.WriteLine(c.Cos(n1));
                }

                else if (action.ToUpper() == "TAN")
                {
                    Console.WriteLine(c.Tan(n1));
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

       