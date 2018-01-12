using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            Console.WriteLine("To check if each corresponding place in two 3 digit numbers sums to the same total, enter the first 3 digit number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            //variables
            int digit1,
                digit2,
                digit3,
                digit4,
                digit5,
                digit6;

            digit1 = number1 / 100;
            number1 = number1 % 100;
            digit2 = number1 / 10;
            number1 = number1 % 10;
            digit3 = number1;

            digit4 = number2 / 100;
            number2 = number2 % 100;
            digit5 = number2 / 10;
            number2 = number2 % 10;
            digit6 = number2;

            //outputs
            if (((digit2 + digit5) == (digit3 + digit6)) && ((digit1 + digit4) == (digit2 + digit5)))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}
