using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Equation
    {
        // Fields
        private double _firstCoefficient;
        public double SecondCoefficient { get; set; }
        public double ThirdCoefficient { get; set; }
        public double Discriminant { get; set; }
        public double FirstRoot { get; set; }
        public double SecondRoot { get; set; }

        // Properties
        public double FirstCoefficient
        {
            set
            {
                try
                {
                    if (value == 0)
                    {
                        throw new Exception("The program doesn't deal with the case where FirstCoefficient = 0 .");
                    }
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    Environment.Exit(0);
                }
                _firstCoefficient = value;
            }
            get
            {
                return _firstCoefficient;
            }
        }

        // Constructor
        public Equation(double firstCoefficient, double secondCoefficient, double thirdCoefficient)
        {
            FirstCoefficient = firstCoefficient;
            SecondCoefficient = secondCoefficient;
            ThirdCoefficient = thirdCoefficient;
        }
        //  Calculation the roots of equation
        public void CalculateRoots()
        {
            Discriminant = Math.Pow(SecondCoefficient, 2) - (4 * FirstCoefficient * ThirdCoefficient);
            if (Discriminant == 0)
            {
                FirstRoot = SecondRoot = -SecondCoefficient / (2 * FirstCoefficient);
            }
            else if (Discriminant > 0)
            {
                FirstRoot = (-SecondCoefficient + Math.Sqrt(Discriminant)) / (2 * FirstCoefficient);
                SecondRoot = (-SecondCoefficient - Math.Sqrt(Discriminant)) / (2 * FirstCoefficient);
            }
            else
            {
                Console.WriteLine($"{ToString()}");
            }
        }

        // Return the roots when Discriminant < 0
        public override string ToString()
        {
            double realPart = -SecondCoefficient / (2 * FirstCoefficient);
            double imaginaryPart = Math.Sqrt(-Discriminant) / (2 * FirstCoefficient);
            return $"First Root = {realPart} + {imaginaryPart}i , Second Root = {realPart} - {imaginaryPart}i .";
        }

        // Display Form of equation
        public void DisplayEquation()
        {
            if (SecondCoefficient == 0)
            {
                Console.WriteLine($"My equation : {FirstCoefficient}X^2 + {ThirdCoefficient} = 0 .");
            }
            else if (ThirdCoefficient == 0)
            {
                Console.WriteLine($"My equation : {FirstCoefficient}X^2 + {SecondCoefficient}X = 0 .");
            }
            else if (SecondCoefficient == 0 && ThirdCoefficient == 0)
            {
                Console.WriteLine($"My equation : {FirstCoefficient}X^2 = 0");
            }
            else
            {
                Console.WriteLine($"My equation : {FirstCoefficient}X^2 + {SecondCoefficient}X + {ThirdCoefficient} = 0 .");
            }
        }
    }
}