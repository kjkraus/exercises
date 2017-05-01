using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    public class PrimeFactors
    {
        static void Main(string[] args)
        {
            MyFermatFactorization();

            int answer = Factorials.Factorial(8);
            Console.WriteLine("Eight factorial = " + answer +".");
        }

        static void MyFermatFactorization()
        {
            double fermatNumber5 = 4294967297;
            double squareRoot = Math.Round(Math.Sqrt(fermatNumber5));

            Console.WriteLine("The fifth Fermat number is 4,294,967,297.");
            Console.WriteLine("Press <ENTER> to being brute force factorization.");

            Console.ReadKey();

            for (int i = 2; i < squareRoot; i++)
            {
                Console.WriteLine("I tried dividing by " + i + ".");

                double factor = fermatNumber5 % i;
                if (factor == 0)
                {
                    Console.WriteLine("The first factor is " + i + ".");
                    break;
                }

            }

        }
    }
}

