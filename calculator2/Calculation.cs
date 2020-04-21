using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator2
{
    public class Calculation
    {
        public double Sum(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Diff(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public string Division(double num1, double num2)
        {
        
            return (Math.Round((num1 / num2), 5)).ToString();
        }

        public double EuclideanDivision(double num1, double num2)
        {
            return num1 % num2;
        }
    }
}
