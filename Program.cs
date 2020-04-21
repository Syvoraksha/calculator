using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = EnterNumber1();
            int a = 10;
            char operation = EnterOperator();
            //int b = EnterNumber2();
            int b = 0;

            switch (operation) 
            {
                case '+':
                    PrintResult(Sum(a, b).ToString());
                    break;
                case '-':
                    PrintResult(Diff(a, b).ToString());
                    break;
                case '*':
                    PrintResult(Multiply(a, b).ToString());
                    break;
                case '/':
                    try
                    {
                        PrintResult(Division(a, b).ToString());
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("you wanted to divide by zero");
                    }
                    break;
            }
            Console.ReadLine();
        }

        static int EnterNumber1()
        {
            while (true)
            {
                Console.WriteLine("Enter first number:");
                int num1;
                if(int.TryParse(Console.ReadLine(), out num1))
                {
                    return num1;
                    
                }
                else { continue; }
                
                
            }
            

        }
        static char EnterOperator()
        {
            while (true)
            {
                Console.WriteLine("Enter operator:");
                char oper = Console.ReadLine()[0];
                if (oper == '+' | oper == '-' | oper == '*' | oper == '/')
                    return oper;

                else
                {
                    Console.WriteLine("Wrong input, try again!");
                    continue;
                }
            }
        }
        static int EnterNumber2()
        {
            while (true)
            {
                
                Console.WriteLine("Enter second number:");
                int num2;
                if (int.TryParse(Console.ReadLine(), out num2))
                {
                    return num2;
                }
                else { continue; }
            }
        }
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Diff(int num1, int num2)
        {
            return num1 - num2;
        }
        static int Division(int num1, int num2)
        {
            return num1 / num2;
        }
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
