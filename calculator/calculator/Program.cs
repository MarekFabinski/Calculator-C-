using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give first number.");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give operation.");
            string operation = Console.ReadLine();
            Console.WriteLine("Give second number.");
            int number2 = int.Parse(Console.ReadLine());

            if (operation == "+")
            {
                int result = number1 + number2;
                Console.WriteLine(number1 + " + " + number2 + " = " + result);
            }

            if (operation == "-")
            {
                int result = number1 - number2;
                Console.WriteLine(number1 + " - " + number2 + " = " + result);
            }

            if (operation == "*")
            {
                int result = number1 * number2;
                Console.WriteLine(number1 + " * " + number2 + " = " + result);
            }

            if (operation == "/")
            {
                int result = number1 / number2;
                Console.WriteLine(number1 + " / " + number2 + " = " + result);
            }

            if (operation == "%")
            {
                int result = number1 % number2;
                Console.WriteLine(number1 + " % " + number2 + " = " + result);
            }

            else
            {
                Console.WriteLine("Wrong operation.");
            }
        }
    }
}