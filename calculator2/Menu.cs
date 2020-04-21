using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator2
{
    public class Menu
    {
        public double EnterNumber1()
        {
            while (true)
            {
                Console.WriteLine("Enter first number:");
                double num1;
                if (double.TryParse(Console.ReadLine(), out num1))
                {
                    return num1;

                }
                else { continue; }
            }
        }
        public char EnterOperator()
        {
            while (true)
            {
                Console.WriteLine("Enter operator:");
                char oper = Console.ReadLine()[0];
                if (oper == '+' | oper == '-' | oper == '*' | oper == '/' | oper == '%')
                    return oper;

                else
                {
                    Console.WriteLine("Wrong input, try again!");
                    continue;
                }
            }
        }
        public double EnterNumber2()
        {
            while (true)
            {

                Console.WriteLine("Enter second number:");
                double num2;
                if (double.TryParse(Console.ReadLine(), out num2))
                {
                    return num2;
                }
                else { continue; }
            }
        }

        public void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
