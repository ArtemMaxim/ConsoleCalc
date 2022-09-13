using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            string oper;
            double b;
            Console.Write("Введите первое значение:" + '\t');
            a = Convert.ToDouble(Console.ReadLine());
            double angle = Math.PI * a / 180.0;
            Console.Write("Введите действие ( +, -, *, /, ^, sin, cos):"+'\t');
            oper = Console.ReadLine();
            switch (oper)
                {
                    case "sin":
                        Console.Write("sin("+a+") = "+ Math.Sin(angle));
                     break;
                     case "cos":
                        Console.Write("cos(" + a + ") = " + Math.Cos(angle));
                    break;
                    default:
                       Console.Write("Введите второе значение:" + '\t');
                       b = Convert.ToDouble(Console.ReadLine());
                        switch (oper)
                        {
                            case "+":
                            Console.Write(a + " + " + b + " =  " + (a + b) + '\n');
                            break;
                        case "-":
                            Console.Write(a + " - " + b + " =  " + (a - b) + '\n');
                            break;
                        case "*":
                            Console.Write(a + " * " + b + " =  " + (a * b) + '\n');
                            break;
                        case "/":
                            Console.Write(a + " / " + b + " =  " + (a / b) + '\n');
                            break;
                        case "^":
                            double res=1;
                            for (int i=1; i<=b;++i)
                            {
                                res *= a;
                            }
                            Console.Write(a + " ^ " + b + " =  " + res + '\n');
                            break;
                        default:
                            Console.Write("Действие выбрано неверно!" + '\n');
                            break;
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
