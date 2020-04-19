using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Exercise_9
{
    class Program
    {
        //Funtion factorial
        static BigInteger Factorial(uint num)
        {
            BigInteger f = 1;
            for (uint i = num; i > 0; i--)
            {
                f *= i;
            }

            return f;
        }

        //Main
        static void Main(string[] args)
        {
            //receiving special character
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Declaring variables
            uint n = 0, x = 0;
            BigInteger sum = 1;

            //Requesting numerator and denominator
            Console.Write(" Enter the number for the limit: ");
            n = Convert.ToUInt32(Console.ReadLine());

            Console.Write(" Enter the denominator: ");
            x = Convert.ToUInt32(Console.ReadLine());

            for (uint i = 1; i <= n; i++)
            {
                sum += Factorial(i) /(BigInteger) Math.Pow(x, i);
            }

            Console.Write("Sum = 1 + 1!/{0} + 2!/{0}² +...+ {1}!/{0}^{1} = {2}", x, n, sum);

            Console.ReadKey();

        }
    }
}
