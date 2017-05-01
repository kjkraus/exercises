using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    public class Factorials
    {
        public static int Factorial(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }

    }

}
