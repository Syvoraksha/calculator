using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            for (; ; )
            {
                double a = menu.EnterNumber1();

                char operation = menu.EnterOperator();
                double b = menu.EnterNumber2();

                Calculation calc = new Calculation();

                switch (operation)
                {
                    case '+':
                        menu.PrintResult(calc.Sum(a, b).ToString());
                        break;
                    case '-':
                        menu.PrintResult(calc.Diff(a, b).ToString());
                        break;
                    case '*':
                        menu.PrintResult(calc.Multiply(a, b).ToString());
                        break;
                    case '/':
                        menu.PrintResult(calc.Division(a, b));
                        break;
                    case '%':
                        menu.PrintResult(calc.EuclideanDivision(a, b).ToString());
                        break;
                }
            }

        }

       
    }
}
