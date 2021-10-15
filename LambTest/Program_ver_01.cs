using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LambTest
{
    public delegate double NuCalc(double num1, double num2);
    class Program
    {
        static string symb;
        static void Main(string[] args)
        {
        Link:
            symb = Console.ReadLine();
            if (symb == "+")
            {
                NuCalc nusum = (num1, num2) => num1 + num2;
                Console.WriteLine("Сумма чисел: {0}", nusum(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
            }
            else if (symb == "-")
            {
                NuCalc nusub = (num1, num2) => num1 - num2;
                Console.WriteLine("Разность чисел: чисел: {0}", nusub(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
            }
            else if (symb == "*" || symb == "/")
            {
                Console.WriteLine("Функции сложения и деления не реализованы");
                goto Link;
            }
            goto Link;
        }
    }
}
