using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T formula<T>(T Arg1 , T Arg2);
    internal class CalculatorClass
    {
        public formula<double> calculate;

        public double GetSum(double Num1, double Num2)
        {
            return Num1 + Num2;
        }
        public double GetDifference(double Num1 , double Num2)
        {
            return Num1 - Num2;
        }
        public double GetProduct(double Num1, double Num2)
        {
            return Num1 * Num2;
        }

        public double GetQuotient(double Num1, double Num2)
        {
            return Num1/Num2;
        }

        public event formula<double> CalculateEvent
        {
            add
            {
                Console.WriteLine("Add the Digits");
                calculate += value;
            }
            remove
            {
                Console.WriteLine("Remove the Digits");
                calculate -= value;
            }
        }
    }
}
